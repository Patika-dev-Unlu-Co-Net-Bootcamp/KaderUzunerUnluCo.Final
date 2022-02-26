using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Domain.Interface;

namespace DataAccess.Concrete.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository Product { get; }
        IColorRepository Color { get; }
        IBrandRepository Brand { get; }
        IOfferableRepository Offerable { get; }
        IUserRepository User { get; }
        ICategoryRepository Category { get; }
        Task<int> SaveChangesAsync();
    }
}
