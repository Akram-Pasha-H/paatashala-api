namespace PaatashalaApi.DTOs
{
    public class EmployeeBCAttendanceData
    {
        
        public long OrgId { get; internal set; }
        public List<long> EmpId { get; set; }
        public string scanDateTime { get; set; }
        public bool IsCheckIn { get; set; }
    }
}
