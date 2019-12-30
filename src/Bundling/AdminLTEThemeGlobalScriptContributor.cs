using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace MicroFeel.Abp.Theme.AdminLTE.Bundling
{
    public class AdminLTEThemeGlobalScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/themes/adminlte/jquery.min.js");
            context.Files.Add("/themes/adminlte/bootstrap.bundle.min.js");
            context.Files.Add("/themes/adminlte/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js");
            context.Files.Add("/themes/adminlte/dist/js/adminlte.js");
            context.Files.Add("/themes/adminlte/dist/js/demo.js");
            context.Files.Add("/themes/adminlte/plugins/chart.js/Chart.js");
            context.Files.Add("/themes/adminlte/dist/js/pages/dashboard2.js");
        }
    }
}