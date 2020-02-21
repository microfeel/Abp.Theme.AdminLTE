using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using MicroFeel.Abp.Theme.AdminLTEDemo.Localization;
using MicroFeel.Abp.Theme.AdminLTEDemo.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace MicroFeel.Abp.Theme.AdminLTEDemo.Web.Menus
{
    public class AdminLTEDemoMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<AdminLTEDemoResource>>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("AdminLTEDemo.Home", l["Menu:Home"], "/"));
        }
    }
}
