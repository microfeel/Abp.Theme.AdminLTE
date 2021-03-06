﻿using System.Threading.Tasks;
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
    public class AdminLTEThemeMainTopToolbarContributor : IToolbarContributor
    {
        public async Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
        {
            if (context.Toolbar.Name != StandardToolbars.Main)
            {
                return;
            }

            if (!(context.Theme is AdminLTETheme))
            {
                return;
            }
            context.Toolbar.Items.Add(new ToolbarItem(typeof(MessagesBarComponent)));
            context.Toolbar.Items.Add(new ToolbarItem(typeof(NotificationsBarComponent)));

            var languageProvider = context.ServiceProvider.GetService<ILanguageProvider>();

            //TODO: This duplicates GetLanguages() usage. Can we eleminate this?
            var languages = await languageProvider.GetLanguagesAsync();
            if (languages.Count > 1)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(LanguageSwitchViewComponent)));
            }

            if (context.ServiceProvider.GetRequiredService<ICurrentUser>().IsAuthenticated)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(UserMenuViewComponent)));
            }
            context.Toolbar.Items.Add(new ToolbarItem(typeof(ControlPanelComponent)));
        }
    }
}
