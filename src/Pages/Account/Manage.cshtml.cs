using Volo.Abp.Identity;

namespace MicroFeel.Abp.Theme.AdminLTE.Pages.Account
{
    public class ManageModel : Volo.Abp.Account.Web.Pages.Account.ManageModel
    {
        public ManageModel(IProfileAppService profileAppService)
            : base(profileAppService)
        {

        }
    }
}
