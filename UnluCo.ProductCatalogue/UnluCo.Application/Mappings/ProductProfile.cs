using AutoMapper;
using Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Application.Dto;
using UnluCo.Entities.Concrete;

namespace Business.Mappings
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
        }

    }
}
