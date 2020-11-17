using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace stackTest
{
    public class stackTestWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<stackTestWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}