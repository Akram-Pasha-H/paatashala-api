using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblOtherProgram
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblAdvanceFeeDebit> TblAdvanceFeeDebits { get; set; } = new List<TblAdvanceFeeDebit>();

    public virtual ICollection<TblAdvancedFeePayment> TblAdvancedFeePayments { get; set; } = new List<TblAdvancedFeePayment>();

    public virtual ICollection<TblAttendanceHourlyOtherProgram> TblAttendanceHourlyOtherPrograms { get; set; } = new List<TblAttendanceHourlyOtherProgram>();

    public virtual ICollection<TblInactiveStudentLog> TblInactiveStudentLogs { get; set; } = new List<TblInactiveStudentLog>();

    public virtual ICollection<TblOtherProgramsStudent> TblOtherProgramsStudents { get; set; } = new List<TblOtherProgramsStudent>();

    public virtual ICollection<TblVisualTimeTablePhotoType> TblVisualTimeTablePhotoTypes { get; set; } = new List<TblVisualTimeTablePhotoType>();
}
