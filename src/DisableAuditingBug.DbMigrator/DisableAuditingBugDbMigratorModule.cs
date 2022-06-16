using DisableAuditingBug.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace DisableAuditingBug.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DisableAuditingBugEntityFrameworkCoreModule),
    typeof(DisableAuditingBugApplicationContractsModule)
    )]
public class DisableAuditingBugDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
