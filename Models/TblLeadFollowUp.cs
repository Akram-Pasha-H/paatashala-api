using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblLeadFollowUp
{
    public long Id { get; set; }

    public long StudentId { get; set; }

    public long? CreatedBy { get; set; }

    public long? AssignTo { get; set; }

    public string? Explanation { get; set; }

    public DateTime? FollowupTime { get; set; }

    public string? Channel { get; set; }

    public string? Remarks { get; set; }

    public long? OrgId { get; set; }

    public bool? IsDismissed { get; set; }

    public long? AdmissionStatus { get; set; }

    public long? ChannelLinked { get; set; }

    public virtual TblAdmissionStatusType? AdmissionStatusNavigation { get; set; }

    public virtual TblEmployee? AssignToNavigation { get; set; }

    public virtual TblEmployee? CreatedByNavigation { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }
}
