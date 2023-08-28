using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTerm
{
    public long Id { get; set; }

    public string? TermName { get; set; }

    public string? Description { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblAolcomment> TblAolcomments { get; set; } = new List<TblAolcomment>();

    public virtual ICollection<TblAolstudentEntry> TblAolstudentEntries { get; set; } = new List<TblAolstudentEntry>();
}
