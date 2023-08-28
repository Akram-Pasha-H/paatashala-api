using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActappraisalHeader
{
    public long Id { get; set; }

    public long? EmployeeId { get; set; }

    public long? OrgId { get; set; }

    public long? Ssid { get; set; }

    public DateTime? Date { get; set; }

    public string? Remarks { get; set; }

    public virtual TblEmployee? Employee { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblActappraisalDetail> TblActappraisalDetails { get; set; } = new List<TblActappraisalDetail>();
}
