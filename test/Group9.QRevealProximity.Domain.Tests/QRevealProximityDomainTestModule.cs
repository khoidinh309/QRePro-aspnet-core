using Group9.QRevealProximity.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Group9.QRevealProximity;

[DependsOn(
    typeof(QRevealProximityEntityFrameworkCoreTestModule)
    )]
public class QRevealProximityDomainTestModule : AbpModule
{

}
