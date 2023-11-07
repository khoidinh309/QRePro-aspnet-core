using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Group9.QRevealProximity.Web;

[Dependency(ReplaceServices = true)]
public class QRevealProximityBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "QRevealProximity";
}
