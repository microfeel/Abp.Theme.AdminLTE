using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace MicroFeel.Abp.Theme.AdminLTE.Components.Header
{
    public class HeaderViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/AdminLTE/Components/Header/Default.cshtml");
        }
    }
}
