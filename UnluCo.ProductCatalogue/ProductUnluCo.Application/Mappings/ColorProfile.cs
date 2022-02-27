using AutoMapper;
using ProductUnluCo.Application.Dto;
using ProductUnluCo.Domain.Models;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.Mappings
{
    public class ColorProfile : Profile
    {
        public ColorProfile()
        {
            CreateMap<ColorDto, Color>().ReverseMap();
        }
    }
}
