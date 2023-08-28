using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTaxDetail
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public long TaxTypeId { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblTaxType TaxType { get; set; } = null!;
}
