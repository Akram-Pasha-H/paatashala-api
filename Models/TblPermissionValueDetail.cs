using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblPermissionValueDetail
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long? StartValue { get; set; }
}
