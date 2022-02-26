using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Entities.Abstract;
using UnluCo.Entities.Concrete;

namespace UnluCo.Domain.Models
{
    public class Brand:IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public List<Product> Products { get; set; }
    }
}
