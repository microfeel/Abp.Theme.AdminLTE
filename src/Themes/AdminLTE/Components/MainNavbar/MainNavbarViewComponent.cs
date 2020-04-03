using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.Settings;

namespace MicroFeel.Abp.Theme.AdminLTE.Components.MainNavbar
{
    public class MainNavbarViewComponent : AbpViewComponent
    {
        private const string MainMenuName = "MainMenuName";
        private const string TitleName = "MenuTitle";

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //获取菜单标题
            var settingprovider = ServiceProvider.GetService<ISettingProvider>();
            var title = await settingprovider.GetOrNullAsync(TitleName);
            var model = new MainNavbarViewComponentModel { Title = title };
            //获取菜单
            var allvalues = await settingprovider.GetAllAsync();
            if (allvalues.Any(s => s.Name == MainMenuName))
            {
                var mainMenuName = await settingprovider.GetOrNullAsync(MainMenuName);
                var toolbarManager = ServiceProvider.GetService<IToolbarManager>();
                if (!string.IsNullOrWhiteSpace(mainMenuName))
                {
                    model.Toolbar = await toolbarManager.GetAsync(mainMenuName);
                }
            }
            return View("~/Themes/AdminLTE/Components/MainNavbar/Default.cshtml", model);
        }
    }
}
