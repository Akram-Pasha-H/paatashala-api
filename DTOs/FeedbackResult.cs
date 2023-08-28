namespace PaatashalaApi.DTOs
{
    public class FeedbackResult
    {
        public long Id { get; set; }
        public long HeaderId { get; set; }
        public long QuestionId { get; set; }
        public int value { get; set; }
    }
    public class FeedbackHeader
    {
        public long StudentId { get; set; }
        public DateTime Date { get; set; }
        public string Comments { get; set; }
        public long OrgId { get; set; }
        public List<FeedbackResult> Result { get; set; }
    }
}
