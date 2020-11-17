using stackTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace stackTest
{
    [DependsOn(
        typeof(stackTestEntityFrameworkCoreTestModule)
        )]
    public class stackTestDomainTestModule : AbpModule
    {

    }
}