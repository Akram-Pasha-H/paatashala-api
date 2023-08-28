using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActmentoringHomeVisit
{
    public long Id { get; set; }

    public DateTime? DateOfVisit { get; set; }

    public long? TeacherId { get; set; }

    public long? StudentId { get; set; }

    public string? DurationOfVisit { get; set; }

    public string? TeacherReflection { get; set; }

    public string? PositiveQuality { get; set; }

    public string? MenteesAttendance { get; set; }

    public string? MenteesPersonality { get; set; }

    public string? MenteesHealth { get; set; }

    public string? MenteesFamilyBackground { get; set; }

    public string? MenteesAcademicProgress { get; set; }

    public string? MenteesBehaviour { get; set; }

    public string RecreationProgramme { get; set; } = null!;

    public string? UnderstandParentalExpectations { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }

    public virtual TblEmployee? Teacher { get; set; }
}
