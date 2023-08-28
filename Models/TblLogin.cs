using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblLogin
{
    public long Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public long UserId { get; set; }

    public long UserType { get; set; }

    public bool IsActive { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblFranchiseDetail> TblFranchiseDetails { get; set; } = new List<TblFranchiseDetail>();

    public virtual ICollection<TblIssueList> TblIssueLists { get; set; } = new List<TblIssueList>();
}
