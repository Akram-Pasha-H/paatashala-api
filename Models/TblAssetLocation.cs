using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAssetLocation
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? OrgId { get; set; }

    public string? Description { get; set; }

    public string? Address { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblAssetRequest> TblAssetRequests { get; set; } = new List<TblAssetRequest>();

    public virtual ICollection<TblAssetTrackingLog> TblAssetTrackingLogs { get; set; } = new List<TblAssetTrackingLog>();

    public virtual ICollection<TblAssetTracking> TblAssetTrackings { get; set; } = new List<TblAssetTracking>();
}
