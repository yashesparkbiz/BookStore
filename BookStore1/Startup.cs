using Microsoft.AspNetCore.Builder;

namespace BookStore1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/", async context =>
                {
                    await context.Response.WriteAsync("Environment : "+env.EnvironmentName);
                });
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
