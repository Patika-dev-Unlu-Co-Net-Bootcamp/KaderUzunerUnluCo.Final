using AutoMapper;
using ProductUnluCo.Application.Dto;
using ProductUnluCo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.Mappings
{
    public class OfferableProfile : Profile
    {
        public OfferableProfile()
        {
            CreateMap<OfferableDto, Offerable>().ReverseMap();
        }
    }
}
