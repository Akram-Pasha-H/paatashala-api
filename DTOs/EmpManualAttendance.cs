namespace PaatashalaApi.DTOs
{
    public class EmpManualAttendance
    {
        public List<EmpManualAttendace> AttendaceObj { get; set; }
        public string dateAttendance { get; set; }
        public long OrgId { get; set; }
    }
}
