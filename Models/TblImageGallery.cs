using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblImageGallery
{
    public long Id { get; set; }

    public long EmpId { get; set; }

    public byte[]? ImageData { get; set; }

    public string? ImageName { get; set; }

    public long? ImageSize { get; set; }

    public long? OrgId { get; set; }

    public long? Course { get; set; }

    public long? Batch { get; set; }

    public virtual TblBatch? BatchNavigation { get; set; }

    public virtual TblCourse? CourseNavigation { get; set; }

    public virtual TblEmployee Emp { get; set; } = null!;

    public virtual TblOrg? Org { get; set; }
}
