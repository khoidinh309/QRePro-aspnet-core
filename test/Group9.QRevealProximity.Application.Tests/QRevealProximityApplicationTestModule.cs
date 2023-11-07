using Volo.Abp.Modularity;

namespace Group9.QRevealProximity;

[DependsOn(
    typeof(QRevealProximityApplicationModule),
    typeof(QRevealProximityDomainTestModule)
    )]
public class QRevealProximityApplicationTestModule : AbpModule
{

}
