using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTaxType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal TaxPercent { get; set; }

    public bool TaxAtSource { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblTaxDetail> TblTaxDetails { get; set; } = new List<TblTaxDetail>();
}
