using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblPayGroupDetail
{
    public long Id { get; set; }

    public long? PayGroupId { get; set; }

    public long? SalaryComponent { get; set; }

    public long? CalculationType { get; set; }

    public long? ComputedOn { get; set; }

    public decimal? Value { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblPayGroup? PayGroup { get; set; }

    public virtual TblEmployeeSalaryComponent? SalaryComponentNavigation { get; set; }
}
