using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Application.Dto;
using UnluCo.Entities.Concrete;

namespace UnluCo.Application.Dto
{
   public class ProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Descripton { get; set; }
        public int CategoryId { get; set; }
        public int? ColorId { get; set; }
        public int? BrandId { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
    }
}
