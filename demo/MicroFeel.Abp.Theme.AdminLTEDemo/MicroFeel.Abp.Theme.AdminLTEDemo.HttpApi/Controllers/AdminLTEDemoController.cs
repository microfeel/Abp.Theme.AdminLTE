using MicroFeel.Abp.Theme.AdminLTEDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MicroFeel.Abp.Theme.AdminLTEDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AdminLTEDemoController : AbpController
    {
        protected AdminLTEDemoController()
        {
            LocalizationResource = typeof(AdminLTEDemoResource);
        }
    }
}