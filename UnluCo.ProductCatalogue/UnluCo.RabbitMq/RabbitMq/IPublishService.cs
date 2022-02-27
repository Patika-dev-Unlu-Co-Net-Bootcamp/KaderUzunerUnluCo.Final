using ProductUnluCo.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Application.RabbitMq
{
   public interface IPublishService
    {
        void Publish(SendMailDto email, string queueName);
    }
}
