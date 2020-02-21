using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace MicroFeel.Abp.Theme.AdminLTEDemo.EntityFrameworkCore
{
    [DependsOn(
        typeof(AdminLTEDemoEntityFrameworkCoreModule)
        )]
    public class AdminLTEDemoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AdminLTEDemoMigrationsDbContext>();
        }
    }
}
