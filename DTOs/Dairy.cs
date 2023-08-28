namespace PaatashalaApi.DTOs
{
    public class Dairy
    {
        public long Id { get; set; }
        public string StudentName { get; set; }
        public bool isPresent { get; set; }
    }

    public class DairyData
    {
        public long? Batch { get; set; }
        public long? Course { get; set; }
        public long? OrgId { get; set; }
        public long? StudentId { get; set; }
        public string? FatherName { get; set; }
        public string? Name { get; set; }
        public string? RegistrationCode { get; set; }
        public string? Sex { get; set; }
    }
}
