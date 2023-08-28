using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class View
{
    public long Id { get; set; }

    public string ViewName { get; set; } = null!;

    public string ViewPath { get; set; } = null!;

    public string ViewContent { get; set; } = null!;

    public long OrgId { get; set; }
}
