using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace MicroFeel.Abp.Theme.AdminLTEDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class AdminLTEDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AdminLTEDemo";
    }
}
