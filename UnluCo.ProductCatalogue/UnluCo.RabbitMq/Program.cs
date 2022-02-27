using Newtonsoft.Json;
using ProductUnluCo.Application.Dto;
using RabbitMQ.Client;
using System;
using System.Text;


namespace UnluCo.RabbitMq
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new SendMailDto
            {
                Subject = "RabbitMQ",
                Body = "RabbitMQ Deneme",
                From = "rabbitmq@deneme.com",
                
            };

            var factory = new ConnectionFactory() { HostName = "localhost" }; //RabbitMQ bağlantımızı oluşturuyoruz
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "UnluCoContext", durable: false, exclusive: false, autoDelete: false, arguments: null);

                string message = JsonConvert.SerializeObject(email); 

                var body = Encoding.UTF8.GetBytes(message); 

                //Mesajı RabbitMQ'ya ekliyoruz
                channel.BasicPublish(exchange: "", routingKey: "UnluCoContext", basicProperties: null, body: body);

                Console.WriteLine("Gönderilen mail içeriği:", message);
            }

            Console.WriteLine(" Mailiniz başarı ile kuyruğa alındı.");
            Console.ReadLine();

        }
    }
}

