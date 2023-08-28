using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAppVersion
{
    public long VersionId { get; set; }

    public DateTime? BuidDate { get; set; }

    public string? Version { get; set; }

    public string? UpdateMessage { get; set; }

    public string? Notes { get; set; }
}
