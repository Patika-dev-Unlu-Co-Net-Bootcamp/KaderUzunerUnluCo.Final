using AutoMapper;
using ProductUnluCo.Application.Dto;
using ProductUnluCo.Application.Interface;
using ProductUnluCo.Domain.Models;
using ProductUnluCo.Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application
{
    public class BrandService : IBrandService
    {
        private readonly IUnitOfWork _unitOfwork;
        private readonly IMapper _mapper;

        public BrandService(IUnitOfWork unitOfwork, IMapper mapper)
        {
            _unitOfwork = unitOfwork;
            _mapper = mapper;
        }
        public async Task Add(BrandDto brandDto)
        {
            var brand = _mapper.Map<Brand>(brandDto);
            await _unitOfwork.Brand.Add(brand);
            await _unitOfwork.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var brand = _mapper.Map<Brand>(id);
            _unitOfwork.Brand.Delete(brand);
            _unitOfwork.SaveChangesAsync();
        }

        public async Task<BrandDto> Get(Expression<Func<Brand, bool>> filter)
        {
            var brand = _unitOfwork.Brand.Get(filter).Result;
            var brandModel = _mapper.Map<BrandDto>(brand);

            return await Task.FromResult(brandModel);
        }

        public async Task<List<BrandDto>> GetAll(Expression<Func<BrandDto, bool>> filter = null)
        {
            var brands = _unitOfwork.Brand.GetAll().Result;

            var brandList = _mapper.Map<List<Brand>, List<BrandDto>>(brands);
            return await Task.FromResult(brandList);
        }

        public async Task<BrandDto> GetById(int id)
        {
            var result = (await _unitOfwork.Brand.Get(x => x.Id == id)).FirstOrDefault();
            if (result != null)
            {
                return _mapper.Map<BrandDto>(result);
            }
            return null;
        }

        public Task Update(int id, BrandDto brandDto)
        {
            throw new NotImplementedException();
        }
    }
}

