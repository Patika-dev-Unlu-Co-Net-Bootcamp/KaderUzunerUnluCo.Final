using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Entities.Abstract;
using UnluCo.Entities.Concrete;

namespace UnluCo.Domain.Models
{
    public class Color:IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public List<Product> Products { get; set; }
    }
}
