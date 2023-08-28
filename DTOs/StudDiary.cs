namespace PaatashalaApi.DTOs
{
    public class StudDiary
    {
        public List<Dairy> AttendaceObj { get; set; }
        public string dateAttendance { get; set; }
        public long OrgId { get; set; }
        public string Comments { get; set; }
        public long BatchId { get; set; }
        public long CourseId { get; set; }
        public string Title { get; set; }
    }
}
