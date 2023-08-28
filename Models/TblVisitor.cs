using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblVisitor
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Mobile { get; set; }

    public string? Address { get; set; }

    public string? VehicleNumber { get; set; }

    public long? ToMeet { get; set; }

    public long? PersonType { get; set; }

    public string? Reason { get; set; }

    public long? VechicleType { get; set; }

    public TimeSpan? InTime { get; set; }

    public TimeSpan? OutTime { get; set; }

    public long OrgId { get; set; }

    public DateTime? Date { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblVisitorMaterial> TblVisitorMaterials { get; set; } = new List<TblVisitorMaterial>();
}
