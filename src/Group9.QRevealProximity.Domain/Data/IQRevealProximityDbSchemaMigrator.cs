using System.Threading.Tasks;

namespace Group9.QRevealProximity.Data;

public interface IQRevealProximityDbSchemaMigrator
{
    Task MigrateAsync();
}
