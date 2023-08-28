namespace PaatashalaApi.DTOs
{
    public class Homework
    {
        public List<Assignments> assignmentsList { get; set; }
        public Homework()
        {
            assignmentsList = new List<Assignments>();
        }
    }
    public class Assignments
    {
        public long AssignmentId { get; set; }
        public string AssignmentName { get; set; }
        public long SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string Date { get; set; }
        public List<Questions> MultipleQuestion { get; set; }
        public Assignments()
        {
            MultipleQuestion = new List<Questions>();
        }
    }
    public class Questions
    {
        public string QuestionsName { get; set; }
    }
}
