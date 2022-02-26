
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Application.Dto;

namespace Business.Abstract
{
    public interface IProductService
    {
        Task Add(ProductDto productDto);
        void Delete(ProductDto productDto);
        void Update(ProductDto productDto);
        Task<List<ProductDto>> GetAll();
        Task<ProductDto> GetById(int id);
        Task<List<ProductDto>> Get(Expression<Func<ProductDto, bool>> filter);
    }
}
