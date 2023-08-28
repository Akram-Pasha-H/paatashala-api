using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblWidget
{
    public long Id { get; set; }

    public string WidgetName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public long? Position { get; set; }

    public virtual ICollection<TblRoleWidget> TblRoleWidgets { get; set; } = new List<TblRoleWidget>();
}
