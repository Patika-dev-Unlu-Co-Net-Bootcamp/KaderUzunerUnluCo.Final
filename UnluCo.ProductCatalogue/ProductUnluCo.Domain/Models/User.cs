using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ProductUnluCo.Domain.Interface;

namespace ProductUnluCo.Domain.Models
{
    public class User : IdentityUser, IEntity

    {
        public virtual IList<Offerable> Offerables { get; set; }
        public virtual IList<Product> Products { get; set; }
        public virtual IList<Category> Categories { get; set; }
    }
}
