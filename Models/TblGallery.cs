using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblGallery
{
    public long Id { get; set; }

    public long OrgId { get; set; }

    public long BatchId { get; set; }

    public long CourseId { get; set; }

    public string? Section { get; set; }

    public int GalleryTypeId { get; set; }

    public Guid GalleryId { get; set; }

    public string FileName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public long FileSize { get; set; }

    public string Caption { get; set; } = null!;

    public long UploadedBy { get; set; }

    public DateTime UploadedOn { get; set; }

    public DateTime LastUpdated { get; set; }

    public byte[]? Thumbnail { get; set; }

    public bool? IsDelete { get; set; }

    public virtual TblBatch Batch { get; set; } = null!;

    public virtual TblCourse Course { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblEmployee UploadedByNavigation { get; set; } = null!;
}
