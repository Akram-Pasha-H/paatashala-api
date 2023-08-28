using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblChannel
{
    public long Id { get; set; }

    public string? ChannelName { get; set; }

    public string? Description { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }
}
