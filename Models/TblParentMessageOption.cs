using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblParentMessageOption
{
    public long Id { get; set; }

    public long ParentMessageBoxId { get; set; }

    public long ParentMessageOptionsId { get; set; }

  
    public virtual TblParentMessageBox ParentMessageBox { get; set; } = null!;

    public virtual TblParentMessageOption1 ParentMessageOptions { get; set; } = null!;
}
