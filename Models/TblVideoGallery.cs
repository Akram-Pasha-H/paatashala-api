using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblVideoGallery
{
    public long Id { get; set; }

    public long? EmpId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime? Date { get; set; }

    public string? Url { get; set; }

    public long? CourseId { get; set; }

    public long? BatchId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblOrg? Org { get; set; }
}
