using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActacademicHandholdingChecklist
{
    public long Id { get; set; }

    public long? SchoolId { get; set; }

    public int? NoOfStudentsEnrolled { get; set; }

    public int? NoOfStaff { get; set; }

    public long? Chairman { get; set; }

    public long? Principal { get; set; }

    public DateTime? DateOfAssessment { get; set; }

    public long? Ssf { get; set; }

    public long? OrgId { get; set; }

    public virtual TblEmployee? ChairmanNavigation { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblEmployee? PrincipalNavigation { get; set; }

    public virtual TblOrg? School { get; set; }

    public virtual TblEmployee? SsfNavigation { get; set; }

    public virtual ICollection<TblActacademicCoordinator> TblActacademicCoordinators { get; set; } = new List<TblActacademicCoordinator>();
}
