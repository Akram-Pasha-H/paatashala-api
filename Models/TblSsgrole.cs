using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblSsgrole
{
    public long Id { get; set; }

    public string RoleName { get; set; } = null!;

    public string? RoleDescription { get; set; }

    public virtual ICollection<TblSsgemployee> TblSsgemployees { get; set; } = new List<TblSsgemployee>();
}
