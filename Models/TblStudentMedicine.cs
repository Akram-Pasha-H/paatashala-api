using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudentMedicine
{
    public long Id { get; set; }

    public long? StudentId { get; set; }

    public DateTime? AdministeredDate { get; set; }

    public long? MedicineId { get; set; }

    public string? Uom { get; set; }

    public long OrgId { get; set; }

    public virtual TblMedicineDetail? Medicine { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
