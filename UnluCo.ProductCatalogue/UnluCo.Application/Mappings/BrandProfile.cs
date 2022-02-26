using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Application.Dto;
using UnluCo.Domain.Models;

namespace UnluCo.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<BrandDto, Brand>().ReverseMap();
        }
    }
}
