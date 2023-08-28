using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAdmissionStatusType
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public bool? IsLead { get; set; }

    public virtual ICollection<TblLeadFollowUp> TblLeadFollowUps { get; set; } = new List<TblLeadFollowUp>();

    public virtual ICollection<TblStudentRegistration> TblStudentRegistrations { get; set; } = new List<TblStudentRegistration>();
}
