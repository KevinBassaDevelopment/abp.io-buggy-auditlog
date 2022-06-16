using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DisableAuditingBug.Data;
using Volo.Abp.DependencyInjection;

namespace DisableAuditingBug.EntityFrameworkCore;

public class EntityFrameworkCoreDisableAuditingBugDbSchemaMigrator
    : IDisableAuditingBugDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDisableAuditingBugDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the DisableAuditingBugDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DisableAuditingBugDbContext>()
            .Database
            .MigrateAsync();
    }
}
