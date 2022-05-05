﻿global using System.ComponentModel.DataAnnotations;
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
using BookStore1.Repository;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using Microsoft.AspNetCore.Identity;
using BookStore1.Helpers;
using BookStore1.Service;
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f

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

            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<BookStoreContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 5;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.SignIn.RequireConfirmedEmail = true;
            });

            services.ConfigureApplicationCookie(config => 
            {
                config.LoginPath = Configuration["Application:LoginPath"];
            });

            services.AddControllersWithViews();
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();
#endif
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>(); 
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ApplicationUserClaimsPrincipalFactory>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IEmailService, EmailService>();
            services.Configure<SMTPConfigModel>(Configuration.GetSection("SMTPConfig"));
            services.Configure<NewBookAlertConfig>("InternalBook",Configuration.GetSection("customobj"));
            services.Configure<NewBookAlertConfig>("ThirdPartyBook",Configuration.GetSection("ThirdPartyBook"));
=======
            services.AddScoped<BookRepository, BookRepository>();
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
            services.AddScoped<BookRepository, BookRepository>();
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
            services.AddScoped<BookRepository, BookRepository>();
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //endpoints.Map("/", async context =>
                //{
                //    await context.Response.WriteAsync("Environment : " + env.EnvironmentName);
                //});
                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{action}/{controller}/{id?}");

                endpoints.MapControllerRoute(
                    name: "MyArea",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                //endpoints.MapControllerRoute(
                //    name: "Aboutus",
                //    pattern: "get-all-books",
                //    defaults: new { controller = "Book", action = "GetAllBooks" });
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
