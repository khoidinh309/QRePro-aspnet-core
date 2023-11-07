using Group9.QRevealProximity.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Group9.QRevealProximity.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(QRevealProximityEntityFrameworkCoreModule),
    typeof(QRevealProximityApplicationContractsModule)
    )]
public class QRevealProximityDbMigratorModule : AbpModule
{
}
