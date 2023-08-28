using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblSsgemployee
{
    public long Id { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public DateTime? DateOfJoining { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public long? RoleId { get; set; }

    public string Email { get; set; } = null!;

    public long? Phone { get; set; }

    public long? Mobile { get; set; }

    public long? AltPhone { get; set; }

    public string Password { get; set; } = null!;

    public bool? IsActive { get; set; }

    public virtual TblSsgrole? Role { get; set; }
}
