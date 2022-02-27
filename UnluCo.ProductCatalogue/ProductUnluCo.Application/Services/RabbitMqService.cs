using ProductUnluCo.Application.Interface;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.Services
{
    public class RabbitMqService : IRabbitMqService
    {
        public IConnection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}
