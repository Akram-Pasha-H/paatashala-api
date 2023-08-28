using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDocument
{
    public long Id { get; set; }

    public long OrgId { get; set; }

    public string? DocName { get; set; }

    public string? DocType { get; set; }

    public string? FileName { get; set; }

    public string? FileExt { get; set; }

    public DateTime? DateCreated { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? LastModifiedBy { get; set; }

    public long? FolderId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual TblDocumentFolder? Folder { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblActwallOfFrameDoc> TblActwallOfFrameDocs { get; set; } = new List<TblActwallOfFrameDoc>();

    public virtual ICollection<TblDocumentAccess> TblDocumentAccesses { get; set; } = new List<TblDocumentAccess>();

    public virtual ICollection<TblDocumentVersion> TblDocumentVersions { get; set; } = new List<TblDocumentVersion>();
}
