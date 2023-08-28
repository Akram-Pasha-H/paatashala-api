using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblHolidayList
{
    public long Id { get; set; }

    public DateTime? Date { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long? OrgId { get; set; }

    public bool? ToParents { get; set; }

    public bool? ToEmployees { get; set; }

    public DateTime? ToDate { get; set; }

    public bool? IsToDateApplicable { get; set; }

    public virtual TblOrg? Org { get; set; }
}
