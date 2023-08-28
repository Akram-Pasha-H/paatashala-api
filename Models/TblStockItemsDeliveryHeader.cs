using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStockItemsDeliveryHeader
{
    public long Id { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public long? StudentId { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public long? OrgId { get; set; }

    public long? RoleId { get; set; }

    public long? TeacherId { get; set; }

    public bool? IsKit { get; set; }

    public long? Kitid { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblRole? Role { get; set; }

    public virtual TblStudent? Student { get; set; }

    public virtual ICollection<TblStockItemDeliveryDetail> TblStockItemDeliveryDetails { get; set; } = new List<TblStockItemDeliveryDetail>();

    public virtual TblEmployee? Teacher { get; set; }
}
