using AutoMapper;
using ProductUnluCo.Application.Dto;
using ProductUnluCo.Application.Interface;
using ProductUnluCo.Domain.Models;
using ProductUnluCo.Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.Services
{
    public class ColorService : IColorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public ColorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }

        public async Task Add(ColorDto colorDto)
        {
            var color = _mapper.Map<Color>(colorDto);
            await _unitOfWork.Color.Add(color);
            await _unitOfWork.SaveChangesAsync();
        }

        public void Delete(ColorDto colorDto)
        {

            var color = _mapper.Map<Color>(colorDto);
            _unitOfWork.Color.Delete(color);
            _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ColorDto>> GetAll()
        {
            var color = await _unitOfWork.Color.GetAll();
            return _mapper.Map<List<ColorDto>>(color);
        }



        public void Update(ColorDto colorDto)
        {
            var color = _mapper.Map<Color>(colorDto);
            _unitOfWork.Color.Update(color);
            _unitOfWork.SaveChangesAsync();
        }
    }
}
