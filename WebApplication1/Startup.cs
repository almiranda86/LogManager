using LogManager.Infrastructure;
using LogManager.Infrastructure.Behavior;
using LogManager.Repository.Behavior;
using LogManager.Repository.Lookup;
using LogManager.Repository.Persister;
using LogManager.Service;
using LogManager.Service.Behavior;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace LogManagerApplication
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

            services.AddSwaggerGen();

            services.AddMediatR(typeof(Startup));

            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IDatabaseConfiguration, DatabaseConfiguration>();
            services.AddTransient<IDbSession, DbSession>();

            services.AddTransient<ILogLookup, LogLookup>();
            services.AddTransient<ILogPersister, LogPersister>();
            services.AddTransient<ILogService, LogService>(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            app.UseSwagger();
            app.UseSwaggerUI();
            
            serviceProvider.GetService<IDatabaseBootstrap>().Setup();

        }
    }
}

