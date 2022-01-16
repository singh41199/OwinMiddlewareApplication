using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Owin;
using Owin;


[assembly: OwinStartup(typeof(OwinMiddleware.Startup))]

namespace OwinMiddleware
{
    public class Startup
    { 
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello From OWIN.");
            });
        }
    }
}
