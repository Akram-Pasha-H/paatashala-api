using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActappraisalDetail
{
    public long Id { get; set; }

    public long? AppraisalHeaderId { get; set; }

    public long? RubricsId { get; set; }

    public int? Score { get; set; }

    public long? OrgId { get; set; }

    public virtual TblActappraisalHeader? AppraisalHeader { get; set; }

    public virtual TblOrg? Org { get; set; }
}
