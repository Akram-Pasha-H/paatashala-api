namespace PaatashalaApi.DTOs
{
    public class SaveStudAttendanceDto
    {
        public List<DailyAttendanceDto> DailyAttendanceObj { get; set; }
        public string dateAttendance { get; set; }
        public long OrgId { get; set; }
    }
}
