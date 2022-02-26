using AutoMapper;
using Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Entities.Concrete;

namespace Business.Mappings
{
    public class OfferableProfile:Profile
    {
        public OfferableProfile()
        {
            CreateMap<OfferableDto, Offerable>().ReverseMap();
        }
    }
}
