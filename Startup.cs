using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace DotNetCoreSample
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context =>{
                return context.Response.WriteAsync("Hello World dot net core");
            });
        }
    }
}