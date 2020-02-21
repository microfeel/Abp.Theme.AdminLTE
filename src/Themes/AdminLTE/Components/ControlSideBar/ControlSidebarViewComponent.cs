using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace MicroFeel.Abp.Theme.AdminLTE.Components.ControlSidebar
{
    public class ControlSidebarViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/AdminLTE/Components/ControlSidebar/Default.cshtml");
        }
    }
}
