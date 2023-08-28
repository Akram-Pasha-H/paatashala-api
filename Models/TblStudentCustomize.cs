using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudentCustomize
{
    public long Id { get; set; }

    public string? FieldName { get; set; }

    public string? FieldType { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
