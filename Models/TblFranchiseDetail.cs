using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblFranchiseDetail
{
    public long Id { get; set; }

    public long ChildOrgId { get; set; }

    public long FinancialYearId { get; set; }

    public decimal? RoyaltyPercentage { get; set; }

    public decimal? RoyaltyFlat { get; set; }

    public string? TermsAndConditions { get; set; }

    public DateTime LastUpdated { get; set; }

    public long UpdatedBy { get; set; }

    public virtual TblOrg ChildOrg { get; set; } = null!;

    public virtual TblFinancialYear FinancialYear { get; set; } = null!;

    public virtual ICollection<TblRoyaltyFeeCollection> TblRoyaltyFeeCollections { get; set; } = new List<TblRoyaltyFeeCollection>();

    public virtual TblLogin UpdatedByNavigation { get; set; } = null!;
}
