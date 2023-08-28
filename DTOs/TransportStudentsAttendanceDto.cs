namespace PaatashalaApi.DTOs
{
    public class TransportStudentsAttendanceDto
    {
        public long CourseId { get; set; }
        public long BatchId { get; set; }
        public long OrgId { get; set; }
        public string AttendanceDate { get; set; }
        public bool Choice { get; set; }
    }
}
