namespace PaatashalaApi.DTOs
{
    public class Exam
    {
        public List<examList> ExamSchedule { get; set; }
        public Exam()
        {
            ExamSchedule = new List<examList>();
        }
    }
    public class examList
    {
        public string Examtype { get; set; }
        public string SubjectName { get; set; }
        public string ExamDate { get; set; }
        public string Duration { get; set; }
        public string Starttime { get; set; }
    }

}
