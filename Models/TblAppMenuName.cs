using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAppMenuName
{
    public long Id { get; set; }

    public string? MenuName { get; set; }

    public string? Url { get; set; }

    public string? Icon { get; set; }

    public virtual ICollection<TblAppMenuDefinition> TblAppMenuDefinitions { get; set; } = new List<TblAppMenuDefinition>();

    public virtual ICollection<TblAppMenuOrg> TblAppMenuOrgs { get; set; } = new List<TblAppMenuOrg>();
}
