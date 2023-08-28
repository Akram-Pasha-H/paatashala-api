using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblLibraryBook
{
    public long Id { get; set; }

    public string? Isbn { get; set; }

    public long LibraryId { get; set; }

    public string? Title { get; set; }

    public long? Category { get; set; }

    public long? Author { get; set; }

    public long? Publication { get; set; }

    public long? Edition { get; set; }

    public long? Volume { get; set; }

    public decimal? Price { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public bool? StudentIssue { get; set; }

    public bool? StaffIssue { get; set; }

    public int? MaxDays { get; set; }

    public string? Series { get; set; }

    public string? PlaceOfPublication { get; set; }

    public string? BookCode { get; set; }

    public long? NoOfPages { get; set; }

    public string? Comments { get; set; }

    public string? ShelfNumber { get; set; }

    public string? BookPosition { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsIssued { get; set; }

    public long? NumberOfCopies { get; set; }

    public long? OrgId { get; set; }

    public virtual TblLibraryBookAuthor? AuthorNavigation { get; set; }

    public virtual TblLibraryBookCategory? CategoryNavigation { get; set; }

    public virtual TblLibraryBookEdition? EditionNavigation { get; set; }

    public virtual TblLibrary Library { get; set; } = null!;

    public virtual TblOrg? Org { get; set; }

    public virtual TblLibraryBookPublication? PublicationNavigation { get; set; }

    public virtual ICollection<TblLibraryBookLedger> TblLibraryBookLedgers { get; set; } = new List<TblLibraryBookLedger>();

    public virtual TblLibraryBookVolume? VolumeNavigation { get; set; }
}
