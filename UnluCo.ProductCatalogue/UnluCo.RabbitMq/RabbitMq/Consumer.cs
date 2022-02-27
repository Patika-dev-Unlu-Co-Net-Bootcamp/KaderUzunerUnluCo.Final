using ProductUnluCo.Application.Dto;
using ProductUnluCo.Application.Interface;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;


namespace UnluCo.Application.RabbitMq
{
    public class Consumer
    {
        private readonly IRabbitMqService _rabbitMqService;
        private readonly IStmpServer _stmpServer;
        public event EventHandler<SendMailDto> MessageReceived;

        public Consumer(IRabbitMqService rabbitMqService, IStmpServer stmpServer)
        {
            _rabbitMqService = rabbitMqService;
            _stmpServer = stmpServer;
        }

        public void Start(string queue)
        {
            var connection = _rabbitMqService.GetConnection();

            var channel = connection.CreateModel();
            //mail kuyruğuna erişiyoruz
            channel.QueueDeclare(queue: "UnluCoContext",
                               durable: false,
                               exclusive: false,
                               autoDelete: false,
                               arguments: null);

            //Kuyruktan mail ile ilgili var olan verileri alıyoruz

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += async (ch, ea) =>
            {
                var message = JsonSerializer.Deserialize<SendMailDto>(Encoding.UTF8.GetString(ea.Body.ToArray()));
                MessageReceived?.Invoke(this, message);
                using var client = _stmpServer.GetSmtpClient();
                try
                {
                    var mailMessage = new MailMessage
                    {
                        Body = message.Body,
                        From = new MailAddress(message.From),
                        Subject = message.Subject,
                        
                    };
                    mailMessage.To.Add(message.To);

                    await client.SendMailAsync(mailMessage);
                    Thread.Sleep(2000);

                }
                catch (Exception e)
                {
                    throw new InvalidOperationException(e.Message);
                }
                finally
                {
                    client.Dispose();
                }
            };
            channel.BasicConsume("UnluCoContext", true, consumer: consumer);
        }

    }
}
