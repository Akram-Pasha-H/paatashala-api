using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblLibraryBookAuthor
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblLibraryBook> TblLibraryBooks { get; set; } = new List<TblLibraryBook>();
}
