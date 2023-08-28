using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActmentorReflection
{
    public long Id { get; set; }

    public long TeacherId { get; set; }

    public int? Month { get; set; }

    public long? MentorScheduleId { get; set; }

    public long? StudentId { get; set; }

    public bool? IsPresent { get; set; }

    public string? Reflection { get; set; }

    public long? OrgId { get; set; }

    public virtual TblActmentoringSchedule? MentorSchedule { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }

    public virtual TblEmployee Teacher { get; set; } = null!;
}
