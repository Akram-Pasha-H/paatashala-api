using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudentKit
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long? Course { get; set; }

    public long? OrgId { get; set; }

    public bool? IsFaculty { get; set; }

    public long? Batch { get; set; }

    public bool? IsApplicableAll { get; set; }

    public virtual TblCourse? CourseNavigation { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblStudentKitItem> TblStudentKitItems { get; set; } = new List<TblStudentKitItem>();
}
