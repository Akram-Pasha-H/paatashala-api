using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblLibrary
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public bool? IsWithinPremises { get; set; }

    public long? BooksCapacity { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblLibraryBook> TblLibraryBooks { get; set; } = new List<TblLibraryBook>();
}
