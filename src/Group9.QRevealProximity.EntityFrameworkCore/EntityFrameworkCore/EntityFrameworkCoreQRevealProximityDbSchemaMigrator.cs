using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Group9.QRevealProximity.Data;
using Volo.Abp.DependencyInjection;

namespace Group9.QRevealProximity.EntityFrameworkCore;

public class EntityFrameworkCoreQRevealProximityDbSchemaMigrator
    : IQRevealProximityDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreQRevealProximityDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the QRevealProximityDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<QRevealProximityDbContext>()
            .Database
            .MigrateAsync();
    }
}
