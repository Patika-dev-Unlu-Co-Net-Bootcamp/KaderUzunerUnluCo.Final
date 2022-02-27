using ProductUnluCo.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.Interface
{
    public interface ICategoryService
    {

        Task Add(CategoryDto categoryDto);
        void Delete(CategoryDto categoryDto);
        void Update(CategoryDto categoryDto);
        Task<List<CategoryDto>> GetAll();
        Task<CategoryDto> GetById(int id);
        Task<List<CategoryDto>> Get(Expression<Func<CategoryDto, bool>> filter);
    }
}
