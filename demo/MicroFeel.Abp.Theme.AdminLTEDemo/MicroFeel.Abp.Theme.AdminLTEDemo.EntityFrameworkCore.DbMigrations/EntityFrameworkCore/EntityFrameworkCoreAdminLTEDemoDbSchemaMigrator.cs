using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MicroFeel.Abp.Theme.AdminLTEDemo.Data;
using Volo.Abp.DependencyInjection;

namespace MicroFeel.Abp.Theme.AdminLTEDemo.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreAdminLTEDemoDbSchemaMigrator
        : IAdminLTEDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAdminLTEDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AdminLTEDemoMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AdminLTEDemoMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}