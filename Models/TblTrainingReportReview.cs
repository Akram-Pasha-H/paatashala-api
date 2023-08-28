using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTrainingReportReview
{
    public long Id { get; set; }

    public long? TrainingNameId { get; set; }

    public string? Introduction { get; set; }

    public string? Objective { get; set; }

    public string? TrainingContent { get; set; }

    public string? Reflection { get; set; }

    public string? Methodology { get; set; }

    public string? Implementation { get; set; }

    public string? TrainingAssignment { get; set; }

    public string? GroupDynamics { get; set; }

    public string? Annexure { get; set; }

    public string? FindUsefulAndInteresting { get; set; }

    public string? KeyLearningFromProgramme { get; set; }

    public string? IrrelavantOrNotMuchUseful { get; set; }

    public string? SuggestionsForImprovements { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblTrainingHeader? TrainingName { get; set; }
}
