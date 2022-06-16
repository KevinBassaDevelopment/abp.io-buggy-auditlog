using System.Threading.Tasks;

namespace DisableAuditingBug.Data;

public interface IDisableAuditingBugDbSchemaMigrator
{
    Task MigrateAsync();
}
