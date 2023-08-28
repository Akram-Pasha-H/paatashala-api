using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAssetTrackingLog
{
    public long Id { get; set; }

    public long? AssetId { get; set; }

    public long? LocationId { get; set; }

    public DateTime? DateTime { get; set; }

    public long? OrgId { get; set; }

    public virtual TblAsset? Asset { get; set; }

    public virtual TblAssetLocation? Location { get; set; }

    public virtual TblOrg? Org { get; set; }
}
