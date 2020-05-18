using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace MicroFeel.Abp.Theme.AdminLTE.Components
{
    public class DataGridViewComponent : AbpViewComponent
    {
        public DataGridViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/");
        }
    }
}
