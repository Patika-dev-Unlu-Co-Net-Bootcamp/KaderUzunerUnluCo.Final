using ProductUnluCo.Application.Dto;
using ProductUnluCo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.Interface
{
    public interface IOfferableService
    {
        Task Add(OfferableDto offerableDto);
        void Delete(OfferableDto offerableDto);
        void Update(OfferableDto offerableDto);
        Task<List<OfferableDto>> GetAll(Expression<Func<Offerable, bool>> filter = null);
        
    }
}
