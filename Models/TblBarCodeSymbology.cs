using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblBarCodeSymbology
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public long Value { get; set; }

    public virtual ICollection<TblGlobalOrgSetting> TblGlobalOrgSettings { get; set; } = new List<TblGlobalOrgSetting>();
}
