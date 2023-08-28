using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblLibraryBookLedger
{
    public long Id { get; set; }

    public bool IsStaff { get; set; }

    public long? PersonId { get; set; }

    public long? BookId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public long? FineAmount { get; set; }

    public long? OrgId { get; set; }

    public long? StudentId { get; set; }

    public long? Batch { get; set; }

    public long? CourseId { get; set; }

    public bool IsReturned { get; set; }

    public long? DepartmentId { get; set; }

    public virtual TblBatch? BatchNavigation { get; set; }

    public virtual TblLibraryBook? Book { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }
}
