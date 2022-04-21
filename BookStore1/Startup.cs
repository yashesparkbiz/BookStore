global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
global using Microsoft.EntityFrameworkCore;
global using BookStore1.Models;
global using BookStore1.Data;


using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.Configuration;
using Microsoft.Extensions.Hosting;
using Pomelo.EntityFrameworkCore.MySql;

namespace BookStore1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<BookStoreContext>(options => options.UseMySql(Configuration.GetConnectionString("Default")));
            services.AddDbContext<BookStoreContext>(options =>
                   options.UseMySql(Configuration.GetConnectionString("Default"), new MySqlServerVersion(new Version())));

            services.AddControllersWithViews();
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();
#endif
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //endpoints.Map("/", async context =>
                //{
                //    await context.Response.WriteAsync("Environment : "+env.EnvironmentName);
                //});
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/yash", async context =>
                {
                    await context.Response.WriteAsync("Hello World from yash");
                });
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from my first middleware  \n");
                await next();
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from my Second middleware  \n");
                await next();
            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from 2nd delegate.  \n");
            });
        }
    }
}
