using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblLibraryBookEdition
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblLibraryBook> TblLibraryBooks { get; set; } = new List<TblLibraryBook>();
}
