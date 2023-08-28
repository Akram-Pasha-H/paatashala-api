namespace PaatashalaApi.DTOs
{
    public class StudentAttendanceDetailDto
    {
        public long Id { get; set; }
        public string StudentName { get; set; }
        public string CheckInTime { get; set; }
        public string CheckOutTime { get; set; }
    }
}
