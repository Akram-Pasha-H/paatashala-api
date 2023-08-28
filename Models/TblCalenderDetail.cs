using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblCalenderDetail
{
    public long Id { get; set; }

    public long? CalenderHeaderId { get; set; }

    public string? EventName { get; set; }

    public DateTime? DatetimeDetail { get; set; }

    public long? OrgId { get; set; }

    public virtual TblCalenderHeaader? CalenderHeader { get; set; }

    public virtual TblOrg? Org { get; set; }
}
