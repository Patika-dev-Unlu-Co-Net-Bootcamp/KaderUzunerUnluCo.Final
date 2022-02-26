using AutoMapper;
using Business.Abstract;
using Business.Mappings;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.Repositories;
using DataAccess.Concrete.UnitOfWorks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Application.Interface;
using UnluCo.Application.Mappings;
using UnluCo.Application.Services;
using UnluCo.Domain.Interface;
using UnluCo.Entities.Concrete;
using UnluCo.Infrastructure.Concrete.Repositories;

namespace UnluCo.Application.DependencyContainer
{
    public static class DependencyExtension
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<UnluCoContext>(options => options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IColorService, ColorService>();
            services.AddScoped<IColorRepository, ColorRepository>();
            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOfferableRepository, OfferableRepository>();
            services.AddScoped<IOfferableService, OfferableService>();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
          
           
        }
    }
}