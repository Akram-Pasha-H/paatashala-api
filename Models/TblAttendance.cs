using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAttendance
{
    public long Id { get; set; }

    public long? StudentId { get; set; }

    public DateTime? Date { get; set; }

    public bool? P1 { get; set; }

    public bool? P2 { get; set; }

    public bool? P3 { get; set; }

    public bool? P4 { get; set; }

    public bool? P5 { get; set; }

    public bool? P6 { get; set; }

    public bool? P7 { get; set; }

    public bool? P8 { get; set; }

    public bool? P9 { get; set; }

    public bool? P10 { get; set; }

    public long? TimeTableId { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblStudent? Student { get; set; }
}
