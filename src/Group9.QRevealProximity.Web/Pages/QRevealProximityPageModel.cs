using Group9.QRevealProximity.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Group9.QRevealProximity.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class QRevealProximityPageModel : AbpPageModel
{
    protected QRevealProximityPageModel()
    {
        LocalizationResourceType = typeof(QRevealProximityResource);
    }
}
