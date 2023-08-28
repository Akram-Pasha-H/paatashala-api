using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDocumentTag
{
    public long Id { get; set; }

    public long? DocId { get; set; }

    public string? TagName { get; set; }

    public long? DocumentVersion { get; set; }

    public long? OrgId { get; set; }

    public long? UserId { get; set; }

    public virtual TblDocumentVersion? Doc { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblEmployee? User { get; set; }
}
