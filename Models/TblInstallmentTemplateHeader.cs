using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblInstallmentTemplateHeader
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long? Course { get; set; }

    public long? Batch { get; set; }

    public long? OrgId { get; set; }

    public virtual TblBatch? BatchNavigation { get; set; }

    public virtual TblCourse? CourseNavigation { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblInstallmentTemplateDetail> TblInstallmentTemplateDetails { get; set; } = new List<TblInstallmentTemplateDetail>();
}
