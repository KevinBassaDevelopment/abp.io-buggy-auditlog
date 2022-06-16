using Volo.Abp.Modularity;

namespace DisableAuditingBug;

[DependsOn(
    typeof(DisableAuditingBugApplicationModule),
    typeof(DisableAuditingBugDomainTestModule)
    )]
public class DisableAuditingBugApplicationTestModule : AbpModule
{

}
