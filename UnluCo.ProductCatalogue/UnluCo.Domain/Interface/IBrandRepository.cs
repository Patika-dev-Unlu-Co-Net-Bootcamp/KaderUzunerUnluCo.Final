using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Domain.Models;

namespace UnluCo.Domain.Interface
{
    public interface IBrandRepository : IRepository<Brand>
    {
        object GetById(int id);
    }
}
