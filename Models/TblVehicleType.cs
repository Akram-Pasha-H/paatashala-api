﻿using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblVehicleType
{
    public long Id { get; set; }

    public string TypeName { get; set; } = null!;

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblVehicle> TblVehicles { get; set; } = new List<TblVehicle>();
}
