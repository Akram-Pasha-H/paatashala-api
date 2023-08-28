using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActssfinteraction
{
    public long Id { get; set; }

    public long? EmpId { get; set; }

    public long? OrgId { get; set; }

    public long? RelatedToOrgId { get; set; }

    public byte[]? Attachment { get; set; }

    public DateTime? Date { get; set; }

    public string? Details { get; set; }

    public long? ModeOfCommunication { get; set; }

    public string? FileName { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblOrg? RelatedToOrg { get; set; }
}
