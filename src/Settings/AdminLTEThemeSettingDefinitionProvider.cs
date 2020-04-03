using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Settings;

namespace MicroFeel.Abp.Theme.AdminLTE.Settings
{
    public class AdminLTEThemeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            context.Add(new SettingDefinition("MenuTitle", "", isVisibleToClients: true));
            context.Add(new SettingDefinition("MainMenuName", "", isVisibleToClients: true));
        }
    }
}
