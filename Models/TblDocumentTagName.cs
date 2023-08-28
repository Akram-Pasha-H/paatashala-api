using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDocumentTagName
{
    public long Id { get; set; }

    public string? TagName { get; set; }

    public bool? IsActive { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblDocumentVersion> TblDocumentVersions { get; set; } = new List<TblDocumentVersion>();
}
