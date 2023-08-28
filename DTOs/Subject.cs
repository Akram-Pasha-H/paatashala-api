namespace PaatashalaApi.DTOs
{
    public class Subject
    {
        public List<Subjects> subjectsList { get; set; }
        public Subject()
        {
            subjectsList = new List<Subjects>();
        }
    }
    public class Subjects
    {
        public long Id { get; set; }
        public string SubjectName { get; set; }
        public string EmployeeName { get; set; }
    }
}
