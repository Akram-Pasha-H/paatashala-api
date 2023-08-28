using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAppLogin
{
    public long Id { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Passcode { get; set; }

    public DateTime? ValidTill { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? SenderId { get; set; }

    public bool? IsRegistered { get; set; }
}
