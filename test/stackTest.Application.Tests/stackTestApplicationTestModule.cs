using Volo.Abp.Modularity;

namespace stackTest
{
    [DependsOn(
        typeof(stackTestApplicationModule),
        typeof(stackTestDomainTestModule)
        )]
    public class stackTestApplicationTestModule : AbpModule
    {

    }
}