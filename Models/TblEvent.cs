using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEvent
{
    public long Id { get; set; }

    public long? EmpId { get; set; }

    public string? EventName { get; set; }

    public long? EventType { get; set; }

    public string? Description { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? ContactPerson { get; set; }

    public long OrgId { get; set; }

    public bool? ToParents { get; set; }

    public bool? ToEmployees { get; set; }

    public bool? IsPersonalized { get; set; }

    public virtual TblEventType? EventTypeNavigation { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
