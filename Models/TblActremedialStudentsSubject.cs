using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActremedialStudentsSubject
{
    public long Id { get; set; }

    public long? ActremedialId { get; set; }

    public long? SubjectId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblSubject? Subject { get; set; }
}
