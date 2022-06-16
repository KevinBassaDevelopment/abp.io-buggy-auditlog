using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DisableAuditingBug.Data;

/* This is used if database provider does't define
 * IDisableAuditingBugDbSchemaMigrator implementation.
 */
public class NullDisableAuditingBugDbSchemaMigrator : IDisableAuditingBugDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
