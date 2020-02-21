using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace MicroFeel.Abp.Theme.AdminLTE.Components.Footer
{
    public class FooterViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/AdminLTE/Components/Footer/Default.cshtml");
        }
    }
}
