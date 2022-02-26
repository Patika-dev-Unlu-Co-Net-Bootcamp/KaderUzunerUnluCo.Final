using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Entities.Concrete;

namespace DataAccess.Concrete.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(UnluCoContext context) : base(context)
        {
        }
    }
}
