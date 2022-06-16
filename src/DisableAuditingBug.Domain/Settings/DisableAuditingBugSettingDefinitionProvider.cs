using Volo.Abp.Settings;

namespace DisableAuditingBug.Settings;

public class DisableAuditingBugSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DisableAuditingBugSettings.MySetting1));
    }
}
