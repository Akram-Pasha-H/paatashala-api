using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblPaatashalaBillingDetail
{
    public long Id { get; set; }

    public long PaatashalaBillingId { get; set; }

    public long? ActiveStudentId { get; set; }

    public long? InActiveStudentId { get; set; }

    public long? OtherProgramStudentId { get; set; }

    public virtual TblStudent? ActiveStudent { get; set; }

    public virtual TblStudent? InActiveStudent { get; set; }

    public virtual TblStudent? OtherProgramStudent { get; set; }
}
