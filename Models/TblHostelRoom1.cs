using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblHostelRoom1
{
    public long Id { get; set; }

    public long? RoomNumber { get; set; }

    public long? RoomRent { get; set; }

    public int? Beds { get; set; }

    public int? TubeLights { get; set; }

    public int? Fan { get; set; }

    public bool? IsActive { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblHostelRoom> TblHostelRooms { get; set; } = new List<TblHostelRoom>();
}
