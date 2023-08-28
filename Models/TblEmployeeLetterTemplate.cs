using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmployeeLetterTemplate
{
    public long Id { get; set; }

    public string? TemplateName { get; set; }

    public string? TemplateContent { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblEmployeeLetter> TblEmployeeLetters { get; set; } = new List<TblEmployeeLetter>();
}
