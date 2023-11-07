using System;
using System.Collections.Generic;
using System.Text;
using Group9.QRevealProximity.Localization;
using Volo.Abp.Application.Services;

namespace Group9.QRevealProximity;

/* Inherit your application services from this class.
 */
public abstract class QRevealProximityAppService : ApplicationService
{
    protected QRevealProximityAppService()
    {
        LocalizationResource = typeof(QRevealProximityResource);
    }
}
