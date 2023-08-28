using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudentRegistration
{
    public long Id { get; set; }

    public long? StudentId { get; set; }

    public long? RegistrationNo { get; set; }

    public string? RegistrationCode { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public long? RegistrationStatus { get; set; }

    public string? LeadNumber { get; set; }

    public long? Stream { get; set; }

    public long? Course { get; set; }

    public long? Batch { get; set; }

    public string? Section { get; set; }

    public long? AdmissionStatus { get; set; }

    public long? CostCenter { get; set; }

    public bool? HasPhoto { get; set; }

    public bool? HasAdmissionLetter { get; set; }

    public bool? HasInterviewDocuments { get; set; }

    public bool? HasBirthCertificate { get; set; }

    public bool? HasLeavingCertificate { get; set; }

    public bool? HasMedicalCertificate { get; set; }

    public bool? HasIncomeCertificate { get; set; }

    public bool? HasCasteCertificate { get; set; }

    public long OrgId { get; set; }

    public virtual TblAdmissionStatusType? AdmissionStatusNavigation { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblStudent? Student { get; set; }
}
