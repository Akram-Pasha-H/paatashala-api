using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAreaOfLearning
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? Course { get; set; }

    public bool? IsActive { get; set; }

    public long? OrgId { get; set; }

    public long? BatchId { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? CourseNavigation { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblAolcomment> TblAolcomments { get; set; } = new List<TblAolcomment>();

    public virtual ICollection<TblThemeAol> TblThemeAols { get; set; } = new List<TblThemeAol>();
}
