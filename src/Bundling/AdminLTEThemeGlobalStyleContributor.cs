using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace MicroFeel.Abp.Theme.AdminLTE.Bundling
{
    public class AdminLTEThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/themes/adminlte/plugins/fontawesome-free/css/all.min.css");
            context.Files.Add("/themes/adminlte/plugins/overlayScrollbars/css/OverlayScrollbars.min.css");
            context.Files.Add("/themes/adminlte/dist/css/adminlte.min.css");
            context.Files.Add("https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700");
        }
    }
}
