using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmployeeAttrition
{
    public long Id { get; set; }

    public long? EmpId { get; set; }

    public DateTime? DateOfRegisteration { get; set; }

    public DateTime? LastWorkingDay { get; set; }

    public long? CheckListId { get; set; }

    public DateTime? ExamInterviewDate { get; set; }

    public string? Remarks { get; set; }

    public long OrgId { get; set; }

    public string? FacetoFaceComments { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblEmployeeAttritionChecklist> TblEmployeeAttritionChecklists { get; set; } = new List<TblEmployeeAttritionChecklist>();
}
