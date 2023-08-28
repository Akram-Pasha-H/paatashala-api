using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblParentCommunication
{
    public long Id { get; set; }

    public long? ToEmpId { get; set; }

    public long? StudentId { get; set; }

    public string? Subject { get; set; }

    public string? MsgContent { get; set; }

    public DateTime? DateSent { get; set; }

    public bool? IsRead { get; set; }

    public int? IsDelete { get; set; }

    public string? FromParentId { get; set; }

    public long? OrgId { get; set; }

    public long? ParentId { get; set; }

    public bool? IsParent { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }

    public virtual TblEmployee? ToEmp { get; set; }
}
