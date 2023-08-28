using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTermCce
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblFormativeAssessmentCce> TblFormativeAssessmentCces { get; set; } = new List<TblFormativeAssessmentCce>();

    public virtual ICollection<TblLearnoMeterCce> TblLearnoMeterCces { get; set; } = new List<TblLearnoMeterCce>();

    public virtual ICollection<TblSummativeAssessmentCce> TblSummativeAssessmentCces { get; set; } = new List<TblSummativeAssessmentCce>();
}
