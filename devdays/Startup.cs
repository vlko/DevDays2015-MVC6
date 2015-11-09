using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Diagnostics;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Hosting;

namespace devdays
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
           services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Add the platform handler to the request pipeline.
            app.UseIISPlatformHandler();
            
            app.UseMvc();
            
            if (!env.IsDevelopment())
            {
               app.UseDeveloperExceptionPage();
            } 
            app.Run(async (context) =>
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync("Missing route!");
            });
        }
    }
}
