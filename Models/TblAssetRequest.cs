using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAssetRequest
{
    public long Id { get; set; }

    public long? AssetId { get; set; }

    public long? RequestLocation { get; set; }

    public DateTime? DateTime { get; set; }

    public long? OrgId { get; set; }

    public long? IsApproved { get; set; }

    public string? RequestReason { get; set; }

    public long? UserId { get; set; }

    public virtual TblAsset? Asset { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblAssetLocation? RequestLocationNavigation { get; set; }
}
