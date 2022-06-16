using DisableAuditingBug.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DisableAuditingBug.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DisableAuditingBugController : AbpControllerBase
{
    protected DisableAuditingBugController()
    {
        LocalizationResource = typeof(DisableAuditingBugResource);
    }
}