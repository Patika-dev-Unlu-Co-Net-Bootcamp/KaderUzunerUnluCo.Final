using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Entities.Concrete;

namespace DataAccess.Concrete.Repositories
{
    public class CategoryRepository: Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(UnluCoContext context) : base(context)
        {

        }
    
    
    }
}
