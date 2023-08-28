using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEventType
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? PersonId { get; set; }

    public long? PersonType { get; set; }

    public long? OrgId { get; set; }

    public bool? IsPersonalized { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblEvent> TblEvents { get; set; } = new List<TblEvent>();
}
