using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblGlobalOrgSetting
{
    public long Id { get; set; }

    public bool? MandatoryFeeOnAdmission { get; set; }

    public long? Country { get; set; }

    public bool? FeePaymentSchedule { get; set; }

    public long? TimeZone { get; set; }

    public long? BarcodeType { get; set; }

    public string? HeaderHtml { get; set; }

    public string? FooterHtml { get; set; }

    public string? TermsAndConditionPayment { get; set; }

    public string? BirthdayEmailContent { get; set; }

    public string? AnniversaryEmailContent { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Smtpserver { get; set; }

    public string? Smtpport { get; set; }

    public string? EmailSenderName { get; set; }

    public string? FeeBodyTemplate { get; set; }

    public long OrgId { get; set; }

    public string? OrgCode { get; set; }

    public string? Udisenumber { get; set; }

    public string? ParentBirthdayEmailContent { get; set; }

    public string? EmployeeBirthdayEmailContent { get; set; }

    public virtual TblBarCodeSymbology? BarcodeTypeNavigation { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
