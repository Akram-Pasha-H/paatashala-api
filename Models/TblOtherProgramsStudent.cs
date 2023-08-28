using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblOtherProgramsStudent
{
    public long Id { get; set; }

    public long? StudentId { get; set; }

    public long? OtherPrograms { get; set; }

    public long? OrgId { get; set; }

    public bool? IsDisabled { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblOtherProgram? OtherProgramsNavigation { get; set; }

    public virtual TblStudent? Student { get; set; }
}
