using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace MicroFeel.Abp.Theme.AdminLTE.Components.MainSideBar
{
    public class MainSideBarComponent : AbpViewComponent
    {
        private readonly IMenuManager _menuManager;
        public MainSideBarComponent(IMenuManager menuManager)
        {
            _menuManager = menuManager;
        }

        public async System.Threading.Tasks.Task<IViewComponentResult> InvokeAsync()
        {
            var menu = await _menuManager.GetAsync(StandardMenus.Main);
            return View("~/Themes/AdminLTE/Components/MainSideBar/Default.cshtml",menu);
        }
    }
}
