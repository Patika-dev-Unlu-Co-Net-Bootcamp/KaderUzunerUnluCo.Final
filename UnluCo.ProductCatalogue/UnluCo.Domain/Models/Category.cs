using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Entities.Abstract;

namespace UnluCo.Entities.Concrete
{
   public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public bool Status { get; set; }
        public List<Product> Products { get; set; }
    }
}
