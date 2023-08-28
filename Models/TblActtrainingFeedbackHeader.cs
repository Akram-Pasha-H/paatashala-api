using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActtrainingFeedbackHeader
{
    public long Id { get; set; }

    public long? TrainingId { get; set; }

    public long? EmpId { get; set; }

    public DateTime? Date { get; set; }

    public string? FindUsefulAndInteresting { get; set; }

    public string? KeyLearningFromProgramme { get; set; }

    public string? IrrelavantOrNotMuchUseful { get; set; }

    public string? SuggestionsForImprovements { get; set; }

    public long? OrgId { get; set; }

    public int? MoodBarometer { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblActtrainingFeedbackDetail> TblActtrainingFeedbackDetails { get; set; } = new List<TblActtrainingFeedbackDetail>();

    public virtual TblTrainingHeader? Training { get; set; }
}
