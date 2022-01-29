using Robot.Core.Repositories;
using Robot.Core.Repositories.Base;
using Robot.Infrastructure.Data;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Robot.Core.Entities;
using Robot.Application.Handler.CommandHandlers;
using Robot.Infrastructure.Repository.Base;

namespace Martians.API
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

            services.AddControllers();
            services.AddDbContext<RobotContext>(options =>
            {
                var server = Configuration["ServerName"];
                var port = "1433";
                var database = Configuration["Database"];
                var user = Configuration["UserName"];
                var password = Configuration["Password"];

                options.UseSqlServer(
                    $"Server={server},{port};Initial Catalog={database};User ID={user};Password={password}",
                    sqlServer => sqlServer.MigrationsAssembly("Martians.API"));
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Martians.API", Version = "v1" });
            });
            services.AddAutoMapper(typeof(Startup));
            services.AddMediatR(typeof(CreateRobotHandler).GetTypeInfo().Assembly);
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IGenericRepository<RobotEntity>, GenericRepository<RobotEntity>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Martians.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
