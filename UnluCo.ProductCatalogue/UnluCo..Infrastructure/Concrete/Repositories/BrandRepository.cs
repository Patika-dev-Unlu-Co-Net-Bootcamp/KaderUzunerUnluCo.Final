using DataAccess.Concrete;
using DataAccess.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Domain.Interface;
using UnluCo.Domain.Models;

namespace UnluCo.Infrastructure.Concrete.Repositories
{
    public class BrandRepository:Repository<Brand>, IBrandRepository
    {
        public BrandRepository(UnluCoContext context) : base(context)
        {

        }

        public object GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
