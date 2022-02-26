using DataAccess.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Application.DependencyContainer;
using UnluCo.Entities.Concrete;

namespace UnluCo.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddMicrosoftIdentityWebApi(Configuration.GetSection("AzureAd"));
            //Lockout user
            services.ConfigureServices(Configuration);
     
            services.AddIdentity<User, IdentityRole>(option =>
            {
                
            }).AddEntityFrameworkStores<UnluCoContext>().AddDefaultTokenProviders();

            //services.AddAuthentication(options =>
            // {
            //     options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //     options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //     options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            // })

            //  .AddJwtBearer(options =>
            //  {
            //      options.SaveToken = true;
            //      options.RequireHttpsMetadata = false;
            //      options.TokenValidationParameters = new TokenValidationParameters
            //      {
            //          ValidateAudience = true,
            //          ValidateIssuer = true,
                  
            //          ValidateIssuerSigningKey = true,
            //          ValidAudience = Configuration["JWTSettings:validAudience"],
            //          ValidIssuer = Configuration["JWTSettings:validIssuer"],
            //          IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWTSettings:securityKey"]))
            //      };
            //  });
         
        
        services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "UnluCo.WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "UnluCo.WebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
