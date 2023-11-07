using Group9.QRevealProximity.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Group9.QRevealProximity.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class QRevealProximityController : AbpControllerBase
{
    protected QRevealProximityController()
    {
        LocalizationResource = typeof(QRevealProximityResource);
    }
}
