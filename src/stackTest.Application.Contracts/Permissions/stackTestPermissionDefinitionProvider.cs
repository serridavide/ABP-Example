using stackTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace stackTest.Permissions
{
    public class stackTestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(stackTestPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(stackTestPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<stackTestResource>(name);
        }
    }
}
