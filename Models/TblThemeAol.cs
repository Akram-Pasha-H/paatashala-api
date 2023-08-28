using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblThemeAol
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? Aol { get; set; }

    public long? OrgId { get; set; }

    public bool? IsActive { get; set; }

    public long? TermId { get; set; }

    public virtual TblAreaOfLearning? AolNavigation { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblActivityAol> TblActivityAols { get; set; } = new List<TblActivityAol>();
}
