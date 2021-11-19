using DashboardProject.Interface;
using DashboardProject.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardProject
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
            var connectionString = Configuration.GetConnectionString($"DBConnection");

            services.AddControllersWithViews().AddNewtonsoftJson(options =>       ///yaha Authentication part lae call gareko xu.
            {
                var resolver = options.SerializerSettings.ContractResolver;
                if (resolver != null)
                    (resolver as DefaultContractResolver).NamingStrategy = null;  // yo query le model ma k id pass vaeko xa tehe ajax list ma rakhnu parxa ab.

                options.SerializerSettings.DateFormatString = "yyyy-MM-dd"; // month must be capital. otherwise it gives minutes.

            });

            services.AddTransient<IDbConnection>(x => new SqlConnection(connectionString));
            services.AddScoped<ICategory, CatRepo>();
            services.AddScoped<IPost, PostRepo>();
            services.AddScoped<IPage, PageRepo>();
            services.AddScoped<ISlider, SliderRepo>();
 
            services.AddControllers();
            services.AddControllersWithViews();

            services.AddSession(options =>       //here i am doing session connections for Login Code
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);      //We set Time here 
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Dashboard}/{id?}");  //action me:Dashboard hoga;

                endpoints.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                
            });
        }
    }
}
