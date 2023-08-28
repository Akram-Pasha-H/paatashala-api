using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblCalenderHeaader
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblCalenderAssignment> TblCalenderAssignments { get; set; } = new List<TblCalenderAssignment>();

    public virtual ICollection<TblCalenderDetail> TblCalenderDetails { get; set; } = new List<TblCalenderDetail>();
}
