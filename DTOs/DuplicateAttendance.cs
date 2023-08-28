namespace PaatashalaApi.DTOs
{
    public class DuplicateAttendance
    {
        public List<Dupicates> DuplicatesList { get; set; }
        public string ReasonDuplicate { get; set; }
        public DuplicateAttendance()
        {
            DuplicatesList = new List<Dupicates>();
        }
    }
    public class Dupicates
    {
        public long StudentId { get; set; }
    }
}
