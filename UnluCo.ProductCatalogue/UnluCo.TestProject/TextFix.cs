using Microsoft.EntityFrameworkCore;
using ProductUnluCo.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.TestProject
{
    public class TextFix
    {
        public ProductDbContext Context { get; set; }

        public TextFix()
        {
            var options = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: "ProductTestDb").Options;
            Context = new ProductDbContext(options);


            Context.Database.EnsureCreated();
            Context.Products.AddRange(Data.GetProductData());
            Context.SaveChanges();
        }
    }
}
