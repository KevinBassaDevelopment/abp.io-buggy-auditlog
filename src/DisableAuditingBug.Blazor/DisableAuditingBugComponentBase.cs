using DisableAuditingBug.Localization;
using Volo.Abp.AspNetCore.Components;

namespace DisableAuditingBug.Blazor;

public abstract class DisableAuditingBugComponentBase : AbpComponentBase
{
    protected DisableAuditingBugComponentBase()
    {
        LocalizationResource = typeof(DisableAuditingBugResource);
    }
}
