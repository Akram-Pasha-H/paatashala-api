using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblRubricsRoleConfiguration
{
    public long Id { get; set; }

    public long? RoleId { get; set; }

    public long? RoleOrgId { get; set; }

    public long? RubricsHeaderId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblRole? Role { get; set; }

    public virtual TblOrg? RoleOrg { get; set; }

    public virtual TblIndicatorGroup? RubricsHeader { get; set; }
}
