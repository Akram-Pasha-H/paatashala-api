using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblInstallmentTemplateDetail
{
    public long Id { get; set; }

    public long HeaderId { get; set; }

    public int? SerialNo { get; set; }

    public decimal? Amount { get; set; }

    public int? DurationBetweenInstallment { get; set; }

    public virtual TblInstallmentTemplateHeader Header { get; set; } = null!;
}
