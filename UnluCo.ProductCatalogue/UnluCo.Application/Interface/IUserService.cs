using Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Entities.Concrete;

namespace Business.Abstract
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
