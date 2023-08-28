namespace PaatashalaApi.DTOs
{
    public class TransportAttendanceDataDto
    {
        public long OrgId { get; set; }
        public string StudentId { get; set; }
        public string scanDateTime { get; set; }
        public bool IsPickUp { get; set; }
        public string Position { get; set; }
    }
}
