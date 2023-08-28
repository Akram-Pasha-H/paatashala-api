using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAsset
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long AssetCategory { get; set; }

    public long? ParentAssetId { get; set; }

    public long OrgId { get; set; }

    public virtual TblAssetCategory AssetCategoryNavigation { get; set; } = null!;

    public virtual ICollection<TblAsset> InverseParentAsset { get; set; } = new List<TblAsset>();

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblAsset? ParentAsset { get; set; }

    public virtual ICollection<TblAssetAttribute> TblAssetAttributes { get; set; } = new List<TblAssetAttribute>();

    public virtual ICollection<TblAssetRequest> TblAssetRequests { get; set; } = new List<TblAssetRequest>();

    public virtual ICollection<TblAssetTrackingLog> TblAssetTrackingLogs { get; set; } = new List<TblAssetTrackingLog>();

    public virtual ICollection<TblAssetTracking> TblAssetTrackings { get; set; } = new List<TblAssetTracking>();
}
