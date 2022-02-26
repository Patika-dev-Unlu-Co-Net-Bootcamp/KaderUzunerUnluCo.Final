using AutoMapper;
using Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Application.Dto;
using UnluCo.Domain.Models;

namespace UnluCo.Application.Mappings
{
    class ColorProfile:Profile
    {
        public ColorProfile()
        {
            CreateMap<ColorDto, Color>().ReverseMap();
        }
    }
}
