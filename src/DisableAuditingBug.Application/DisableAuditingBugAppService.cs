using System;
using System.Collections.Generic;
using System.Text;
using DisableAuditingBug.Localization;
using Volo.Abp.Application.Services;

namespace DisableAuditingBug;

/* Inherit your application services from this class.
 */
public abstract class DisableAuditingBugAppService : ApplicationService
{
    protected DisableAuditingBugAppService()
    {
        LocalizationResource = typeof(DisableAuditingBugResource);
    }
}
