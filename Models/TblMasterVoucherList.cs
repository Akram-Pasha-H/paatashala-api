using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblMasterVoucherList
{
    public long Id { get; set; }

    public string VoucherName { get; set; } = null!;

    public virtual ICollection<TblVoucherList> TblVoucherLists { get; set; } = new List<TblVoucherList>();
}
