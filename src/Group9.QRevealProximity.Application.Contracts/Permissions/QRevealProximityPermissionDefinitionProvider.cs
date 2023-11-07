using Group9.QRevealProximity.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Group9.QRevealProximity.Permissions;

public class QRevealProximityPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(QRevealProximityPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(QRevealProximityPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<QRevealProximityResource>(name);
    }
}
