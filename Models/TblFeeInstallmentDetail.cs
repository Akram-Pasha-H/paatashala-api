using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblFeeInstallmentDetail
{
    public long Id { get; set; }

    public long? CourseId { get; set; }

    public long? InstallmentOrder { get; set; }

    public long? DurationDays { get; set; }

    public decimal? MinFeeAmount { get; set; }

    public long OrgId { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
