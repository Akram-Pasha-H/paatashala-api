namespace PaatashalaApi.DTOs
{
    public class StudentBCAttendanceDataDto
    {
        public long OrgId { get; set; }
        public string StudentId { get; set; }
        public string scanDateTime { get; set; }
        public bool IsCheckIn { get; set; }
    }
}
