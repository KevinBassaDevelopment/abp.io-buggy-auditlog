using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Auditing;

namespace DisableAuditingBug.Controllers;

[AllowAnonymous]
[Route("api/buggy-again")]
public class BuggyController : DisableAuditingBugController
{
    [HttpPost("log-something")]
    [DisableAuditing]
    public async Task LogSomething([FromBody] SeriLogDto[] body)
    {
        // DisableAuditing is ignored. Each call of "api/buggy-again/log-something" is logged in auditlogs
    }
}

public class SeriLogDto
{
    #region PROPERTIES

    public DateTime Timestamp { get; set; }
    public string Level { get; set; }
    public string? MessageTemplate { get; set; }
    public string? RenderedMessage { get; set; }
    public AgentCustomProperties Properties { get; set; }

    #endregion
}

public class AgentCustomProperties
{
    #region PROPERTIES

    public string? AgentAuthKey { get; set; }
    public string? AgentVersion { get; set; }
    public DateTime TimeStamp { get; set; }

    #endregion
}