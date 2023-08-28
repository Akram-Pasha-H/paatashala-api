using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblIndicatorGroup
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public string? Description { get; set; }

    public long OrgId { get; set; }

    public int? FrequencyNumber { get; set; }

    public int? FrequencyType { get; set; }

    public bool? IsLinkedWithClass { get; set; }

    public bool? IsLinkedWithSchool { get; set; }

    public bool? IsLinkedWithSsf { get; set; }

    public bool? IsLinkedWithPrincipal { get; set; }

    public bool? IsLinkedWithHod { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblIndicatorConfig> TblIndicatorConfigs { get; set; } = new List<TblIndicatorConfig>();

    public virtual ICollection<TblIndicatorResultHeader> TblIndicatorResultHeaders { get; set; } = new List<TblIndicatorResultHeader>();

    public virtual ICollection<TblRubricsConfiguration> TblRubricsConfigurations { get; set; } = new List<TblRubricsConfiguration>();

    public virtual ICollection<TblRubricsRoleConfiguration> TblRubricsRoleConfigurations { get; set; } = new List<TblRubricsRoleConfiguration>();
}
