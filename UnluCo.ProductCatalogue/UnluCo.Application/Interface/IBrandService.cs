using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Application.Dto;
using UnluCo.Domain.Models;

namespace UnluCo.Application.Interface
{
    public interface IBrandService
    {
        Task Add(BrandDto brandDto);
        void Delete(int id);
        Task Update(int id, BrandDto brandDto);
        Task<List<BrandDto>> GetAll(Expression<Func<BrandDto, bool>> filter = null);
        Task<BrandDto> Get(Expression<Func<Brand, bool>> filter);
        Task<BrandDto> GetById(int id);
    }
}
