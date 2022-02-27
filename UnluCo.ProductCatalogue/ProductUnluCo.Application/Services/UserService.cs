using AutoMapper;
using ProductUnluCo.Application.Dto;
using ProductUnluCo.Application.Interface;
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
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        public async Task Add(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _unitOfWork.User.Add(user);
            await _unitOfWork.SaveChangesAsync();
        }

        public void Delete(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDto> Get(Expression<Func<User, bool>> filter)
        {
            var user = _unitOfWork.User.Get(filter).Result;
            var userModel = _mapper.Map<UserDto>(user);
            return await Task.FromResult(userModel);
        }

        public async Task<List<UserDto>> GetAll(Expression<Func<User, bool>> filter = null)
        {
            var users = _unitOfWork.User.GetAll().Result;
            var userList = _mapper.Map<List<User>, List<UserDto>>(users);
            return await Task.FromResult(userList);
        }


        public Task<UserDto> GetById(int id)
        {
            throw new NotImplementedException();
            //var user = _unitOfWork.User.GetById(id).Result;
            //var userModel = _mapper.Map<UserDto>(user);
            //return await Task.FromResult(userModel);
        }

        public void Update(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _unitOfWork.User.Update(user);
            _unitOfWork.SaveChangesAsync();
        }


    }
}
