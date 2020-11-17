using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace stackTest.Data
{
    /* This is used if database provider does't define
     * IstackTestDbSchemaMigrator implementation.
     */
    public class NullstackTestDbSchemaMigrator : IstackTestDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}