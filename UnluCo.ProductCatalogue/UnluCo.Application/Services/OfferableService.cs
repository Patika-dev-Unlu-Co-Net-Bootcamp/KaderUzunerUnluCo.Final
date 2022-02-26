using AutoMapper;
using Business.Abstract;
using Business.Dto;
using DataAccess.Abstract;
using DataAccess.Concrete.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Entities.Concrete;

namespace UnluCo.Application.Services
{
    public class OfferableService : IOfferableService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private IOfferableRepository _offerableRepository;

        public OfferableService(IUnitOfWork unitOfWork, IMapper mapper, IOfferableRepository offerableRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _offerableRepository = offerableRepository;
        }

       

        public Task Add(OfferableDto offerableDto, string UserId)
        {
            throw new NotImplementedException();
        }


        //public async Task Add(OfferableDto offerableDto)
        //{
        //    var offerable = _mapper.Map<Offerable>(offerableDto);
        //    await _offerablerepository.Add(offerable);
        //   // _mapper.Map<OfferableDto>(offerable);
        //    await _unitOfWork.SaveChangesAsync();
        //}

        public void Delete(OfferableDto offerableDto)
        {
            var offerable = _mapper.Map<Offerable>(offerableDto);
           
            _unitOfWork.Offerable.Delete(offerable);
            _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<OfferableDto>> GetAll()
        {
            var result = await _unitOfWork.Product.GetAll();
            return _mapper.Map<List<OfferableDto>>(result);
        }

        public async Task<List<OfferableDto>> GetAll(Expression<Func<Offerable, bool>> filter = null)
        {
            var dto = _mapper.Map<Expression<Func<Offerable, bool>>>(filter);
            var offerable = await _unitOfWork.Offerable.Get(dto);
            return _mapper.Map<List<OfferableDto>>(offerable);
        }

        public void Update(OfferableDto offerableDto)
        {
            var offerable = _mapper.Map<Offerable>(offerableDto);
            _unitOfWork.Offerable.Update(offerable);
            _unitOfWork.SaveChangesAsync();
        }

       
    }
}
