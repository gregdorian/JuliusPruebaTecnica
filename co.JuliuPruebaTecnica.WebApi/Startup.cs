using co.JuliusPruebaTecnica.Aplicacion.Interfaces;
using co.JuliusPruebaTecnica.Aplicacion.Services;
using co.JuliusPruebaTecnica.Domain.Core;
using co.JuliusPruebaTecnica.Domain.Core.Interfaces.Repositories;
using co.JuliusPruebaTecnica.Domain.Core.Interfaces.Services;
using co.JuliusPruebaTecnica.InfraestructureData.Model;
using co.JuliusPruebaTecnica.InfraestructureData.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.JuliuPruebaTecnica.WebApi
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

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration["JWT:Issuer"],
                        ValidAudience = Configuration["JWT:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(Configuration["JWT:ClaveSecreta"])
                        )
                    };
                });


            ////Servicios de la capa de aplicación con servicios
            //services.AddScoped(typeof(IBaseAppService<>), typeof(BaseAppService<>));
            //services.AddScoped<IPostsAppService, PostsAppService>();


            //////el dominio a los de infraestructura
            //services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            //services.AddScoped<IPostsService, PostsService>();

            //////infraestructura o persistencia
            //services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            //services.AddScoped<IPostsRepository, PostRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "co.JuliuPruebaTecnica.WebApi", Version = "v1" });
            });

            //options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=realpageDB;Trusted_Connection=True;");
            services.AddDbContext<JuliusContext>(options =>   options.UseSqlServer(
            Configuration.GetConnectionString("JuliusConn")));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "co.JuliuPruebaTecnica.WebApi v1"));
            }

            app.UseRouting();

            // AÑADIMOS EL MIDDLEWARE DE AUTENTICACIÓN
            // DE USUARIOS AL PIPELINE DE ASP.NET CORE
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
