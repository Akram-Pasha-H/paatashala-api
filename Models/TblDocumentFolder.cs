using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDocumentFolder
{
    public long Id { get; set; }

    public string FolderName { get; set; } = null!;

    public long? ParentFolderId { get; set; }

    public long? OrgId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblDocfolderAccess> TblDocfolderAccesses { get; set; } = new List<TblDocfolderAccess>();

    public virtual ICollection<TblDocument> TblDocuments { get; set; } = new List<TblDocument>();
}
