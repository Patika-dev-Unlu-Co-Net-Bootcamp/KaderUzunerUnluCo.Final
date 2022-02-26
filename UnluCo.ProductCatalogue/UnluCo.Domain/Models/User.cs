using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Entities.Abstract;

namespace UnluCo.Entities.Concrete
{
    public class User:IdentityUser,IEntity

    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public IList<Offerable> Offerables { get; set; }
        public IList<Product> Products { get; set; }
    }
}
