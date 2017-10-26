using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using GolfDeptAppp.Data.Interfaces;
using GolfDeptAppp.Data.mocks;
using Microsoft.Extensions.Configuration;
using GolfDeptAppp.Data;
using Microsoft.EntityFrameworkCore;
using GolfDeptAppp.Data.Repositories;
using GolfDeptAppp.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GolfDeptAppp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        private IConfigurationRoot _configurationRoot;
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {//configure dependency injection aka services
            // Server configuration
            services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                 .AddEntityFrameworkStores<AppDbContext>();

            services.AddTransient<IClubRepository, ClubRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShoppingCart.GetCart(sp));

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseIdentity();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "orderdetails",
                    template: "Order/CheckoutComplete/{orderId?}",
                    defaults: new { Controller = "Order", action = "CheckoutComplete" });

                routes.MapRoute(
                    name: "clubdetails",
                    template: "Club/Details/{clubId?}",
                    defaults: new { Controller = "Club", action = "Details" });

                routes.MapRoute(name: "categoryFilter", template: "Club/{action}/{categoryId?}",
                    defaults: new { Controller = "Club", action = "List" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{Id?}");

            });

            DbInitializer.Seed(app);

        }
    }
}
