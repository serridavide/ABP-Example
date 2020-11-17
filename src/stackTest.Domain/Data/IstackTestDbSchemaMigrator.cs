using System.Threading.Tasks;

namespace stackTest.Data
{
    public interface IstackTestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
