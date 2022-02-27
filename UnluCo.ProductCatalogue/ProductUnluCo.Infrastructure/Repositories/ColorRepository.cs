using ProductUnluCo.Domain.Interface;
using ProductUnluCo.Domain.Models;
using ProductUnluCo.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Infrastructure.Repositories
{
    public class ColorRepository : Repository<Color>, IColorRepository
    {
        public ColorRepository(ProductDbContext context) : base(context)
        {

        }

    }
}
