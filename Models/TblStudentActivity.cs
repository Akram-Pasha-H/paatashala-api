using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudentActivity
{
    public long Id { get; set; }

    public long BatchId { get; set; }

    public long OrgId { get; set; }

    public long CourseId { get; set; }

    public long StudentId { get; set; }

    public long ActivityTypeId { get; set; }

    public string? WhatActivity { get; set; }

    public string? HowMuch { get; set; }

    public string? ActivityTime { get; set; }

    public string? Comments { get; set; }

    public DateTime? ActivityDate { get; set; }

    public virtual TblStudentActivityType ActivityType { get; set; } = null!;

    public virtual TblBatch Batch { get; set; } = null!;

    public virtual TblCourse Course { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblStudent Student { get; set; } = null!;
}
