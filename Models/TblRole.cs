using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblRole
{
    public long Id { get; set; }

    public string? RoleName { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblEmployeeGroupDetail> TblEmployeeGroupDetails { get; set; } = new List<TblEmployeeGroupDetail>();

    public virtual ICollection<TblEmployee> TblEmployees { get; set; } = new List<TblEmployee>();

    public virtual ICollection<TblInactiveEmployeeLog> TblInactiveEmployeeLogs { get; set; } = new List<TblInactiveEmployeeLog>();

    public virtual ICollection<TblInactiveEmployee> TblInactiveEmployees { get; set; } = new List<TblInactiveEmployee>();

    public virtual ICollection<TblRolePermission> TblRolePermissions { get; set; } = new List<TblRolePermission>();

    public virtual ICollection<TblRoleWidget> TblRoleWidgets { get; set; } = new List<TblRoleWidget>();

    public virtual ICollection<TblRubricsRoleConfiguration> TblRubricsRoleConfigurations { get; set; } = new List<TblRubricsRoleConfiguration>();

    public virtual ICollection<TblStockItemsDeliveryHeader> TblStockItemsDeliveryHeaders { get; set; } = new List<TblStockItemsDeliveryHeader>();

    public virtual ICollection<TblStudentFeedbackMobileAppQuestion> TblStudentFeedbackMobileAppQuestions { get; set; } = new List<TblStudentFeedbackMobileAppQuestion>();
}
