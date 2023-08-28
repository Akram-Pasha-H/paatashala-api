using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblIndicatorDescriptor
{
    public long Id { get; set; }

    public long? IndicatorDetailId { get; set; }

    public int? Score { get; set; }

    public string? Descriptor { get; set; }

    public long? OrgId { get; set; }
}
