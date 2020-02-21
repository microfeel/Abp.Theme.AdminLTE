using MicroFeel.Abp.Theme.AdminLTEDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MicroFeel.Abp.Theme.AdminLTEDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AdminLTEDemoEntityFrameworkCoreDbMigrationsModule),
        typeof(AdminLTEDemoApplicationContractsModule)
        )]
    public class AdminLTEDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
