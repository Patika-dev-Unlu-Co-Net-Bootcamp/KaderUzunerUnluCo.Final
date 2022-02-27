using ProductUnluCo.Application.Dto;
using ProductUnluCo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.Interface
{
    public interface IUserService
    {
        Task Add(UserDto userDto);
        void Delete(UserDto userDto);
        void Update(UserDto userDto);
        Task<List<UserDto>> GetAll(Expression<Func<User, bool>> filter = null);
        Task<UserDto> Get(Expression<Func<User, bool>> filter);
        Task<UserDto> GetById(int id);
    }
}
