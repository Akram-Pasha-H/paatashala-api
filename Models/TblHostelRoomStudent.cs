using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblHostelRoomStudent
{
    public long Id { get; set; }

    public long? HostelRoomId { get; set; }

    public long? PersonId { get; set; }

    public long? PersonType { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public long? BillingType { get; set; }

    public long OrgId { get; set; }

    public virtual TblHostelRoom? HostelRoom { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
