using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BookAPI.Configuration;
using BookAPI.Data;
using BookAPI.Repositories;
using BookAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace BookAPI
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


            services.Configure<ConnectionStrings>(Configuration.GetSection("ConnectionStrings"));

            services.AddDbContext<RegistrationContext>();

            services.AddControllers();

            services.AddTransient<IRegistrationContext, RegistrationContext>();

            services.AddTransient<IAuthorRepository, AuthorRepository>();

            services.AddTransient<IBookGenreRepository, BookGenreRepository>();

            services.AddTransient<IBookRepository, BookRepository>();

            services.AddTransient<ISupplierRepository, SupplierRepository>();

            services.AddTransient<IRegistrationService, RegistrationService>();









            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "BookAPI",
                    Version = "v1",
                    Description = "Through this API you can access authors and books.",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact()
                    {
                        Email = "dominic.ho@student.howest.be",
                        Name = "Dominic Ho"
                    },
                    License = new Microsoft.OpenApi.Models.OpenApiLicense()
                    {
                        Url = new Uri("https://opensource.org/licenses/MIT")
                    }
                });

                //Met XML Swagger bewerken
                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

                c.IncludeXmlComments(xmlCommentsFullPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment() || env.IsEnvironment("Docker"))
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                    {// swagger naar Route verplaatsen (localhost:5000/index.html)
                        c.SwaggerEndpoint("/swagger/v1/swagger.json", "BookAPI v1");
                        //  c.RoutePrefix = "";
                    });

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
