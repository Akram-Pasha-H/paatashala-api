using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTrainingAttendance
{
    public long Id { get; set; }

    public DateTime? Date { get; set; }

    public long? TrainingHeaderId { get; set; }

    public long EmpId { get; set; }

    public bool? IsPresent { get; set; }

    public virtual TblEmployee Emp { get; set; } = null!;

    public virtual TblTrainingHeader? TrainingHeader { get; set; }
}
