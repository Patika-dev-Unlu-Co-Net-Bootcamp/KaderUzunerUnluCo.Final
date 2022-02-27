using ProductUnluCo.Infrastructure.Context;
using ProductUnluCo.Infrastructure.Repositories;
using System;
using Xunit;

namespace UnluCo.TestProject
{
    public class ProductRepositoryTests : IClassFixture<TextFix>
    {
        private readonly ProductDbContext _context;
        public ProductRepositoryTests(TextFix Fixt)
        {
            _context = Fixt.Context;
        }


        [Fact]
        public void GetAll_ProductList()
        {
            var repository = new ProductRepository(_context);
            var products = repository.GetAll();

            Assert.NotEmpty(products);
            Assert.Equal(4, products.Count());
        }



        [Fact]
        public void Get_return()
        {
            var repository = new ProductRepository(_context);
            var products = repository.Get(x => x.ProductName == "Ayakkabý");
            Assert.NotEmpty(products);
        }
    }
}
