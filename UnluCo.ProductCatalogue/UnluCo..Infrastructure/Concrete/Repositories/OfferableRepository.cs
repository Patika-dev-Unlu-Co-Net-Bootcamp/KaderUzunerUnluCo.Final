using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Entities.Concrete;

namespace DataAccess.Concrete.Repositories
{
    public  class OfferableRepository:Repository<Offerable>, IOfferableRepository
    {
        public OfferableRepository(UnluCoContext context) : base(context)
        {

        }

    }
}
