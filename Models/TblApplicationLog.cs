using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblApplicationLog
{
    public long Id { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? ActionName { get; set; }

    public string? ControllerName { get; set; }

    public string? RouteData { get; set; }

    public string? UserType { get; set; }

    public long? UserId { get; set; }

    public long? OrgId { get; set; }
}
