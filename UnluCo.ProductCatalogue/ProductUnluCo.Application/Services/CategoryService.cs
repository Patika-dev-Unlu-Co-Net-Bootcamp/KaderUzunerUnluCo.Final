using AutoMapper;
using ProductUnluCo.Application.Dto;
using ProductUnluCo.Application.Interface;
using ProductUnluCo.Domain.Interface;
using ProductUnluCo.Domain.Models;
using ProductUnluCo.Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private ICategoryRepository _categoryRepository;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task Add(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            await _unitOfWork.Category.Add(category);
            await _unitOfWork.SaveChangesAsync();
        }


        public void Delete(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            _unitOfWork.Category.Delete(category);
            _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<CategoryDto>> Get(Expression<Func<CategoryDto, bool>> filter)
        {
            var dto = _mapper.Map<Expression<Func<Category, bool>>>(filter);
            var category = await _unitOfWork.Category.Get(dto);
            return _mapper.Map<List<CategoryDto>>(category);
        }

        public async Task<List<CategoryDto>> GetAll()
        {
            var result = await _unitOfWork.Category.GetAll();
            return _mapper.Map<List<CategoryDto>>(result);
        }

        public async Task<CategoryDto> GetById(int id)
        {
            var result = (await _unitOfWork.Category.Get(x => x.CategoryId == id)).FirstOrDefault();
            if (result != null)
            {
                return _mapper.Map<CategoryDto>(result);
            }
            return null;
        }

        public void Update(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            _categoryRepository.Update(category);
            _unitOfWork.SaveChangesAsync();
        }
    }
}
