using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace MicroFeel.Abp.Theme.AdminLTE
{
    [ThemeName(Name)]
    public class AdminLTETheme : ITheme, ITransientDependency
    {
        public const string Name = "AdminLTE";
        public const string NavToolBar = "NavToolBar";
        public const string MainMenu = "Main";

        public string GetLayout(string name, bool fallbackToDefault = true)
        {
            switch (name)
            {
                case StandardLayouts.Application:
                    return "~/Themes/AdminLTE/Layouts/Application.cshtml";
                case StandardLayouts.Account:
                    return "~/Themes/AdminLTE/Layouts/Account.cshtml";
                case StandardLayouts.Empty:
                    return "~/Themes/AdminLTE/Layouts/Empty.cshtml";
                default:
                    return fallbackToDefault ? "~/Themes/AdminLTE/Layouts/Application.cshtml" : null;
            }
        }
    }
}
