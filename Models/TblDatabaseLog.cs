using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDatabaseLog
{
    public long Id { get; set; }

    public string? CommandText { get; set; }

    public string? Parameters { get; set; }

    public long? UserId { get; set; }

    public long? OrgId { get; set; }
}
