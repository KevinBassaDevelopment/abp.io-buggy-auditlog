using DisableAuditingBug.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DisableAuditingBug.Permissions;

public class DisableAuditingBugPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DisableAuditingBugPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DisableAuditingBugPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DisableAuditingBugResource>(name);
    }
}
