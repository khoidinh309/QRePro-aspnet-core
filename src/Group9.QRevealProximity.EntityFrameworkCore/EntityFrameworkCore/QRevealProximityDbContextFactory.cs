using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Group9.QRevealProximity.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class QRevealProximityDbContextFactory : IDesignTimeDbContextFactory<QRevealProximityDbContext>
{
    public QRevealProximityDbContext CreateDbContext(string[] args)
    {
        QRevealProximityEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<QRevealProximityDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new QRevealProximityDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Group9.QRevealProximity.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
