using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.Dto
{
   
        public class SendMailDto
        {
            public string From { get; set; }
            public string To { get; set; }
            public string Body { get; set; }
            public string Subject { get; set; }
        }
    
}
