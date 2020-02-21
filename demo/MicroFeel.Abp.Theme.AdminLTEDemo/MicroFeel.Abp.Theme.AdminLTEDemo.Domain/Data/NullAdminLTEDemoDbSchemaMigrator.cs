using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MicroFeel.Abp.Theme.AdminLTEDemo.Data
{
    /* This is used if database provider does't define
     * IAdminLTEDemoDbSchemaMigrator implementation.
     */
    public class NullAdminLTEDemoDbSchemaMigrator : IAdminLTEDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}