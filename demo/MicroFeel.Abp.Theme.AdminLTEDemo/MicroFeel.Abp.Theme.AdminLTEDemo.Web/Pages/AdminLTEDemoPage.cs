using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using MicroFeel.Abp.Theme.AdminLTEDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MicroFeel.Abp.Theme.AdminLTEDemo.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits MicroFeel.Abp.Theme.AdminLTEDemo.Web.Pages.AdminLTEDemoPage
     */
    public abstract class AdminLTEDemoPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<AdminLTEDemoResource> L { get; set; }
    }
}
