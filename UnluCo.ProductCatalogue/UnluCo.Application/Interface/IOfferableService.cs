using Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Entities.Concrete;

namespace Business.Abstract
{
    public  interface IOfferableService
    {
        Task Add(OfferableDto offerableDto, string UserId);
        void Delete(OfferableDto offerableDto);
        void Update(OfferableDto offerableDto);
        Task<List<OfferableDto>> GetAll(Expression<Func<Offerable, bool>> filter = null);
    }
}
