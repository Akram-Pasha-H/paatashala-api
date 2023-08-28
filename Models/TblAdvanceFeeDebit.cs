using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAdvanceFeeDebit
{
    public long Id { get; set; }

    public long? StudentId { get; set; }

    public long? FeePaymentDetailId { get; set; }

    public long? FeePaidHeaderId { get; set; }

    public decimal? Amount { get; set; }

    public long? OrgId { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public long? OtherCourseId { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblStudentFeePaidHeader? FeePaidHeader { get; set; }

    public virtual TblFeePaymentDetail? FeePaymentDetail { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblOtherProgram? OtherCourse { get; set; }

    public virtual TblStudent? Student { get; set; }
}
