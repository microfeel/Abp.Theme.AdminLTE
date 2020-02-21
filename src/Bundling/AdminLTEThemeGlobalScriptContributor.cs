using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace MicroFeel.Abp.Theme.AdminLTE.Bundling
{
    public class AdminLTEThemeGlobalScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js");
            context.Files.Add("/themes/adminlte/js/adminlte.js");
            context.Files.Add("/themes/adminlte/js/layout.js");
        }
    }
}