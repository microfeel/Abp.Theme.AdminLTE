using MicroFeel.Abp.Theme.AdminLTEDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MicroFeel.Abp.Theme.AdminLTEDemo.Permissions
{
    public class AdminLTEDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AdminLTEDemoPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AdminLTEDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AdminLTEDemoResource>(name);
        }
    }
}
