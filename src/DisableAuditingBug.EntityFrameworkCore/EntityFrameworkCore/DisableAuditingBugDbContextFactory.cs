using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DisableAuditingBug.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class DisableAuditingBugDbContextFactory : IDesignTimeDbContextFactory<DisableAuditingBugDbContext>
{
    public DisableAuditingBugDbContext CreateDbContext(string[] args)
    {
        DisableAuditingBugEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<DisableAuditingBugDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new DisableAuditingBugDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../DisableAuditingBug.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
