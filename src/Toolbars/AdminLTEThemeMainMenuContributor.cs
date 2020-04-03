using System.Threading.Tasks;
using MicroFeel.Abp.Theme.AdminLTE.Components.Toolbar.MessagesBar;
using MicroFeel.Abp.Theme.AdminLTE.Components.Toolbar.NotificationsBar;
using MicroFeel.Abp.Theme.AdminLTE.Components.Toolbar.LanguageSwitch;
using MicroFeel.Abp.Theme.AdminLTE.Components.Toolbar.ControlPanel;
using MicroFeel.Abp.Theme.AdminLTE.Components.Toolbar.UserMenu;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.Localization;
using Volo.Abp.Users;

namespace MicroFeel.Abp.Theme.AdminLTE.Toolbars
{
    public class AdminLTEThemeMainMenuContributor : IToolbarContributor
    {
        public async Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
        {
            if (context.Toolbar.Name != AdminLTETheme.MainMenu)
            {
                return;
            }

            if (!(context.Theme is AdminLTETheme))
            {
                return;
            }

            //var items =  await menuProvider.GetMenuItemsAsync();
            ////var items = await menuProvider.GetMenuItemsAsync();
            //if (items.Count > 1)
            //{
            //    context.Toolbar.Items.Add(new ToolbarItem(typeof(ViewComponent)));
            //}
        }
    }
}
