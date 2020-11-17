using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace stackTest.EntityFrameworkCore
{
    [DependsOn(
        typeof(stackTestEntityFrameworkCoreModule)
        )]
    public class stackTestEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<stackTestMigrationsDbContext>();
        }
    }
}
