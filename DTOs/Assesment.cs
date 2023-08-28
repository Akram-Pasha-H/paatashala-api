namespace PaatashalaApi.DTOs
{
    public class Assesment
    {
        public List<AssesmentList> Reports { get; set; }
        public Assesment()
        {
            Reports = new List<AssesmentList>();
        }
    }

    public class AssesmentList
    {
        public string Examtype { get; set; }
        public string SubjectName { get; set; }
        public decimal Marks { get; set; }
    }
}
