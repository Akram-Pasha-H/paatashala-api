using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActconfiguration
{
    public long Id { get; set; }

    public long? ActorgId { get; set; }

    public long? SchoolOrgId { get; set; }
}
