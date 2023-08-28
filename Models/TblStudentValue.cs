using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudentValue
{
    public long Id { get; set; }

    public long? FieldId { get; set; }

    public string? Value { get; set; }

    public long StudentId { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblStudent Student { get; set; } = null!;
}
