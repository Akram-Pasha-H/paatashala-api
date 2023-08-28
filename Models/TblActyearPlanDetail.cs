using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActyearPlanDetail
{
    public long Id { get; set; }

    public long? HeaderId { get; set; }

    public int? Month { get; set; }

    public int? NoOfWorkingDays { get; set; }

    public int? NoOfTeachingPeriods { get; set; }

    public string? TopicToBeTaught { get; set; }

    public int? NoOfAssessmentPeriod { get; set; }

    public string? NatureOfAssessment { get; set; }

    public int? NoOfPeriodsForFieldTrip { get; set; }

    public string? PlaceForFieldTrip { get; set; }

    public string? StatusOfCompletion { get; set; }

    public string? ReasonForDeviation { get; set; }

    public virtual TblActyearPlanHeader? Header { get; set; }
}
