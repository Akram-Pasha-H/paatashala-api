using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDocumentAccess
{
    public long Id { get; set; }

    public long? DocId { get; set; }

    public long? UserId { get; set; }

    public bool IsRead { get; set; }

    public bool? IsWrite { get; set; }

    public virtual TblDocument? Doc { get; set; }

    public virtual TblEmployee? User { get; set; }
}
