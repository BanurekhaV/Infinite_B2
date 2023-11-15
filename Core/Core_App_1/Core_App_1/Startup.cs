using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_App_1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
           // services.AddControllersWithViews();
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
            }
            //user defined middlewares
            //first middleware
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Middle Ware 1 : Request \n");
            //    await next();
            //    await context.Response.WriteAsync("Middle Ware 1 : Response \n");
            //});

            ////second Middleware
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Middle Ware 2 : Request \n");
            //    await next();
            //    await context.Response.WriteAsync("Middle Ware 2 : Response \n");
            //});

            ////terminal middleware
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Middle Ware 3 : Both Request and Response \n");
            //});
            //Inorder to make the Index.html as the start page
            //DefaultFilesOptions dfo = new DefaultFilesOptions();
            //dfo.DefaultFileNames.Clear();
            //dfo.DefaultFileNames.Add("Index.html");
            //app.UseDefaultFiles(dfo);
            // app.UseStaticFiles();

            //In the above,we are using 2 Middlewares viz. defaultfiles, staticfiles
            //we can avoid the above and instead use a single middleware FileServerOptions
            FileServerOptions fso = new FileServerOptions();
            fso.DefaultFilesOptions.DefaultFileNames.Clear();
            fso.DefaultFilesOptions.DefaultFileNames.Add("Index.html");
            app.UseFileServer(fso);
           // app.UseRouting();
           

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapDefaultControllerRoute();
            //});
            //app.UseEndpoints(endpoints =>
            //{

            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //        await context.Response.WriteAsync("Worker process Name : " +
            //            System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            //    });
            //});
        }
    }
}
