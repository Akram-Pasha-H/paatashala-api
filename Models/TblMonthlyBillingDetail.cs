using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblMonthlyBillingDetail
{
    public long Id { get; set; }

    public long BillingDataId { get; set; }

    public long CourseId { get; set; }

    public long BatchId { get; set; }

    public long StudentId { get; set; }

    public virtual TblBatch Batch { get; set; } = null!;

    public virtual TblMonthlyBillingDatum BillingData { get; set; } = null!;

    public virtual TblCourse Course { get; set; } = null!;

    public virtual TblStudent Student { get; set; } = null!;
}
