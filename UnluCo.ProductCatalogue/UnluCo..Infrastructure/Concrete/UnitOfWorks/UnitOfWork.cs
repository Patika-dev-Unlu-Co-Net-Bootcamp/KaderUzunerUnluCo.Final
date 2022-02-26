using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Domain.Interface;
using UnluCo.Entities.Concrete;

namespace DataAccess.Concrete.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICategoryRepository Category { get; }

        public IOfferableRepository Offerable { get; }
        public IProductRepository Product { get; }
        public IUserRepository User { get; }    
        public IColorRepository Color { get; }
        public IBrandRepository Brand { get; }


        private readonly UnluCoContext _context;

        public UnitOfWork(UnluCoContext context, ICategoryRepository categoryRepository, IProductRepository productRepository,IUserRepository userRepository,IOfferableRepository offerableRepository,IColorRepository colorRepository,IBrandRepository brandRepository)
        {
            _context = context;
           
            Category = categoryRepository;
            Product = productRepository;
            Offerable = offerableRepository;
            User = userRepository;
            Color = colorRepository;
            Brand = brandRepository;
        }

        public async Task<int> SaveChangesAsync()
        {

            return await _context.SaveChangesAsync();
        }
    }
}
