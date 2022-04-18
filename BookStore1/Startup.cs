using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;


namespace BookStore1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
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
