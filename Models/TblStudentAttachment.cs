using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudentAttachment
{
    public long Id { get; set; }

    public long StudentId { get; set; }

    public string? FileName { get; set; }

    public long? FileSizeInBytes { get; set; }

    public byte[]? Attachment { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblStudent Student { get; set; } = null!;
}
