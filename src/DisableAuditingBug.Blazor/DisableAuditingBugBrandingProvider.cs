using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DisableAuditingBug.Blazor;

[Dependency(ReplaceServices = true)]
public class DisableAuditingBugBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DisableAuditingBug";
}
