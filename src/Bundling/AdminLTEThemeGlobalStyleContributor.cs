using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace MicroFeel.Abp.Theme.AdminLTE.Bundling
{
    public class AdminLTEThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/libs/Ionicons/css/ionicons.min.css");
            context.Files.Add("/plugins/overlayScrollbars/css/OverlayScrollbars.min.css");
            context.Files.Add("/themes/adminlte/css/adminlte.min.css");
            //context.Files.Add("/themes/adminlte/css/layout.css");
            //context.Files.Add("https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700");
        }
    }
}
