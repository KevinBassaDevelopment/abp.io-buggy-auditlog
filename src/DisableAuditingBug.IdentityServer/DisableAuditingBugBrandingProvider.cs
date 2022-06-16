using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace DisableAuditingBug;

[Dependency(ReplaceServices = true)]
public class DisableAuditingBugBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DisableAuditingBug";
}
