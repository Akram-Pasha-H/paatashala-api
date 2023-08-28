namespace PaatashalaApi.DTOs
{
    public class studentActReport
    {
        public List<ActivityReportDto> StudentListObj { get; set; }
        public string ActivityDate { get; set; }
        public long OrgId { get; set; }
        public long BatchId { get; set; }
        public long CourseId { get; set; }
        public long ActivityId { get; set; }
        public string WhatDid { get; set; }
        public string Comments { get; set; }
        public string When { get; set; }
        public string HowMuch { get; set; }
    }
}
