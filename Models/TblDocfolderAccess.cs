using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDocfolderAccess
{
    public long Id { get; set; }

    public long? FolderId { get; set; }

    public long? UserId { get; set; }

    public bool? ReadFolder { get; set; }

    public bool? WriteFolder { get; set; }

    public virtual TblDocumentFolder? Folder { get; set; }

    public virtual TblEmployee? User { get; set; }
}
