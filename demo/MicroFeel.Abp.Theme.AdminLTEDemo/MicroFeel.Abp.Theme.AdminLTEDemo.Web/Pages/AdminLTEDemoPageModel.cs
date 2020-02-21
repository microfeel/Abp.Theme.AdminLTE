using MicroFeel.Abp.Theme.AdminLTEDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MicroFeel.Abp.Theme.AdminLTEDemo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AdminLTEDemoPageModel : AbpPageModel
    {
        protected AdminLTEDemoPageModel()
        {
            LocalizationResourceType = typeof(AdminLTEDemoResource);
        }
    }
}