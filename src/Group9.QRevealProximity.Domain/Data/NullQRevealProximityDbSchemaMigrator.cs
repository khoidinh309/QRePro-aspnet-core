using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Group9.QRevealProximity.Data;

/* This is used if database provider does't define
 * IQRevealProximityDbSchemaMigrator implementation.
 */
public class NullQRevealProximityDbSchemaMigrator : IQRevealProximityDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
