using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActwallOfFrameDoc
{
    public long Id { get; set; }

    public long? DocId { get; set; }

    public long? DocVersionId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long OrgId { get; set; }

    public virtual TblDocument? Doc { get; set; }

    public virtual TblDocumentVersion? DocVersion { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
