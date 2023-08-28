using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTripParticipant
{
    public long Id { get; set; }

    public DateTime? Date { get; set; }

    public long? TripSheetId { get; set; }

    public long? PersonId { get; set; }

    public long? PersonTypeId { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblTripSheet? TripSheet { get; set; }
}
