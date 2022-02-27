using ProductUnluCo.Application.Dto;
using ProductUnluCo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.TestProject
{
    public static class Data
    {
        public static IList<Product> GetProductData()
        {


            var result = new List<Product>
            {
                new Product {ProductId = 1,  ProductName = "Çanta",Price=100},
                new Product {ProductId = 2,  ProductName = "Ayakkabı",Price=50},
                new Product {ProductId = 3,  ProductName = "Saat",Price=25},
                new Product {ProductId = 4,  ProductName = "Gözlük",Price=25},

            }.AsQueryable();

            return result;
        }

        public static ProductDto GetProductDto()
        {
            return new ProductDto { ProductName = "Ayakkabı" };
        }
    }
}
