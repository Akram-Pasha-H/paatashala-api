namespace PaatashalaApi.DTOs
{
    public class DaycareStudentsAttendanceDto
    {
        public long BatchId { get; set; }
        public long CourseId { get; set; }
        public long OrgId { get; set; }
        public string AttendanceDate { get; set; }
    }
}
