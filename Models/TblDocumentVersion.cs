using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDocumentVersion
{
    public long Id { get; set; }

    public long? DocId { get; set; }

    public string? DocTag { get; set; }

    public byte[]? DocData { get; set; }

    public int? VersionNumber { get; set; }

    public long? ModifiedBy { get; set; }

    public TimeSpan? TimeStamp { get; set; }

    public long OrgId { get; set; }

    public bool? IsDismiss { get; set; }

    public long? DocTagId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual TblDocument? Doc { get; set; }

    public virtual TblDocumentTagName? DocTagNavigation { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblActwallOfFrameDoc> TblActwallOfFrameDocs { get; set; } = new List<TblActwallOfFrameDoc>();

    public virtual ICollection<TblDocumentTag> TblDocumentTags { get; set; } = new List<TblDocumentTag>();
}
