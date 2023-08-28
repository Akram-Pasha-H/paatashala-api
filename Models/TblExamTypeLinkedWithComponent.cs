using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblExamTypeLinkedWithComponent
{
    public long Id { get; set; }

    public long? SubjectLinkedExamTypeId { get; set; }

    public long? SubComponenetId { get; set; }
}
