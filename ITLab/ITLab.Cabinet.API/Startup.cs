using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using ITLab.Cabinet.API.configs;
using ITLab.Cabinet.Logic.ReadServices;
//using Autofac;
//using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Newtonsoft.Json.Serialization;
using ITLab.Cabinet.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace ITLab.Cabinet.API
{
    public class Startup
    {
        readonly string devCors = "_AllowAllOrigins";
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            // In ASP.NET Core 3.0 `env` will be an IWebHostEnvironment, not IHostingEnvironment.
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)

                .AddEnvironmentVariables();
            this.Configuration = builder.Build();
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public ILifetimeScope AutofacContainer { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // Serializer setup for PascalCase
            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });

            services.AddAutofac();

            // CORS Policy setup (Allow all)
            services.AddCors(options =>
            {
                options.AddPolicy(name: devCors,
                                  builder =>
                                  {
                                      builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();

                                  });
            });

            services.AddDbContext<CabinetContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("CabinetConnection")));
        }
        public void ConfigureContainer(ContainerBuilder builder)
        {

            // Register your own things directly with Autofac, like:
            builder.RegisterModule(new ITLabCabinetAutofacConfig());
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            this.AutofacContainer = app.ApplicationServices.GetAutofacRoot();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //TODO: allow all cors must be here, for prod must be only specific cors policy
            }

            app.UseCors(devCors);

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
