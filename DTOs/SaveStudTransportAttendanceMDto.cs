namespace PaatashalaApi.DTOs
{
    public class SaveStudTransportAttendanceMDto
    {
        public List<DailyAttendanceDto> DailyTransportAttendanceObj { get; set; }
        public string dateAttendance { get; set; }
        public long OrgId { get; set; }
        public bool Choice { get; set; }
    }
}
