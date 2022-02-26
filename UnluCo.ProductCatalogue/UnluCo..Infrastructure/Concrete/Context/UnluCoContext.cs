using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Entities.Concrete;
using System.Threading;
using UnluCo.Domain.Models;

namespace DataAccess.Concrete
{
    public class UnluCoContext : IdentityDbContext<User>
    {
        public UnluCoContext(DbContextOptions<UnluCoContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Offerable> Offerables { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }

        
    }
}
