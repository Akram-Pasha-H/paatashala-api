using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblHostelRoom
{
    public long Id { get; set; }

    public long? HostelId { get; set; }

    public long? RoomId { get; set; }

    public long OrgId { get; set; }

    public virtual TblHostel? Hostel { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblHostelRoom1? Room { get; set; }

    public virtual ICollection<TblHostelRoomStudent> TblHostelRoomStudents { get; set; } = new List<TblHostelRoomStudent>();
}
