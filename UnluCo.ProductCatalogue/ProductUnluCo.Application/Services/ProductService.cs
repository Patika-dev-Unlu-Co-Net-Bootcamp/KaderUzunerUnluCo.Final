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
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private IProductRepository _productRepository;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper, IProductRepository productRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task Add(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _productRepository.Add(product);
            _mapper.Map<ProductDto>(productDto);
            await _unitOfWork.SaveChangesAsync();
        }



        public void Delete(ProductDto productDto)
        {

            var product = _mapper.Map<Product>(productDto);
            //_unitOfWork.Product.Get(i => i.ProductId == id);
            _unitOfWork.Product.Delete(product);
            _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ProductDto>> Get(Expression<Func<ProductDto, bool>> filter)
        {
            var dto = _mapper.Map<Expression<Func<Product, bool>>>(filter);
            var result = await _unitOfWork.Product.Get(dto);
            return _mapper.Map<List<ProductDto>>(result);
        }

        public async Task<List<ProductDto>> GetAll()
        {
            var result = await _unitOfWork.Product.GetAll();
            return _mapper.Map<List<ProductDto>>(result);
        }

        public async Task<ProductDto> GetById(int id)
        {
            var result = (await _unitOfWork.Product.Get(x => x.ProductId == id)).FirstOrDefault();
            if (result != null)
            {
                return _mapper.Map<ProductDto>(result);
            }
            return null;
        }

        public void Update(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            _unitOfWork.Product.Update(product);
            _unitOfWork.SaveChangesAsync();
        }


    }
}
