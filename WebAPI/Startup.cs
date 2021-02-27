using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
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
        /*
            services.addsingleton<�carservice, carmanager>();
            services.addsingleton<�cardal, efcardal>();

            services.addsingleton<�brandservice, brandmanager>();
            services.addsingleton<�branddal, efbranddal>();

            services.addsingleton<�colorservice, colormanager>();
            services.addsingleton<�colordal, efcolordal>();

            services.addsingleton<�customerservice, customermanager>();
            services.addsingleton<�customerdal, efcustomerdal>();

            services.addsingleton<�rentalservice, rentalmanager>();
            services.addsingleton<�rentaldal, efrentaldal>();

            services.addsingleton<�userservice, usermanager>();
            services.addsingleton<�userdal, efuserdal>();
        */
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseStaticFiles();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
