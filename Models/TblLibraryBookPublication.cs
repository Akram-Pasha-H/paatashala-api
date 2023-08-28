﻿using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblLibraryBookPublication
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblLibraryBook> TblLibraryBooks { get; set; } = new List<TblLibraryBook>();
}