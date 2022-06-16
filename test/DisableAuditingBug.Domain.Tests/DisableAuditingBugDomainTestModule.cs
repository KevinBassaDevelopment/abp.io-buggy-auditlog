using DisableAuditingBug.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DisableAuditingBug;

[DependsOn(
    typeof(DisableAuditingBugEntityFrameworkCoreTestModule)
    )]
public class DisableAuditingBugDomainTestModule : AbpModule
{

}
