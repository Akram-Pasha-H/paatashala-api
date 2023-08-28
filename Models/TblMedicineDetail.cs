using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblMedicineDetail
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Company { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblStudentMedicine> TblStudentMedicines { get; set; } = new List<TblStudentMedicine>();
}
