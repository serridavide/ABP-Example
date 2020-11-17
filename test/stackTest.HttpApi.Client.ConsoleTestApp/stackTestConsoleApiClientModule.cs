using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace stackTest.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(stackTestHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class stackTestConsoleApiClientModule : AbpModule
    {
        
    }
}
