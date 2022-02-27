using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductUnluCo.Domain.Interface;
using ProductUnluCo.Infrastructure.Context;
using ProductUnluCo.Infrastructure.Repositories;
using ProductUnluCo.Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Infrastructure.DependencyContainer
{
    public static class DependencyExtension
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {

            //services.AddDbContext<ProductDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IColorRepository, ColorRepository>();

            services.AddScoped<IBrandRepository, BrandRepository>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOfferableRepository, OfferableRepository>();


            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        }

    }
}
