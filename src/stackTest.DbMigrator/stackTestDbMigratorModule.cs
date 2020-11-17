using stackTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace stackTest.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(stackTestEntityFrameworkCoreDbMigrationsModule),
        typeof(stackTestApplicationContractsModule)
        )]
    public class stackTestDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
