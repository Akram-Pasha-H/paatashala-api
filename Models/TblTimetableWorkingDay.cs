using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTimetableWorkingDay
{
    public long Id { get; set; }

    public bool? Sunday { get; set; }

    public bool? Monday { get; set; }

    public bool? Tuesday { get; set; }

    public bool? Wednesday { get; set; }

    public bool? Thrusday { get; set; }

    public bool? Friday { get; set; }

    public bool? Saturday { get; set; }

    public long? TimetableId { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
