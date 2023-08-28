using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblLoginUserType
{
    public long Id { get; set; }

    public long UserTypeId { get; set; }

    public string? Description { get; set; }
}
