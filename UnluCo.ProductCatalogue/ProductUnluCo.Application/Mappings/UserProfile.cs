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
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<RegisterDto, User>().ReverseMap();

        }
    }

}
