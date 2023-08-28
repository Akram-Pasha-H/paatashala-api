using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActacademicCoordinator
{
    public long Id { get; set; }

    public long? AcademicHandholdingId { get; set; }

    public long? CoordinatorId { get; set; }

    public virtual TblActacademicHandholdingChecklist? AcademicHandholding { get; set; }
}
