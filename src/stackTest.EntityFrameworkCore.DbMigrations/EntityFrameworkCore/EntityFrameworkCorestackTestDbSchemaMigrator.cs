using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using stackTest.Data;
using Volo.Abp.DependencyInjection;

namespace stackTest.EntityFrameworkCore
{
    public class EntityFrameworkCorestackTestDbSchemaMigrator
        : IstackTestDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorestackTestDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the stackTestMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<stackTestMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}