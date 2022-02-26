using DataAccess.Concrete;
using DataAccess.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Domain.Interface;
using UnluCo.Domain.Models;

namespace UnluCo.Infrastructure.Concrete.Repositories
{
    public  class ColorRepository: Repository<Color>, IColorRepository
    {
        public ColorRepository(UnluCoContext context) : base(context)
        {

        }
    
    }
}
