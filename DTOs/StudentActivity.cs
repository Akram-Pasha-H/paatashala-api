namespace PaatashalaApi.DTOs
{
    public class StudentActivity
    {
        public string Photo { get; set; }
        public string OrgName { get; set; }
        public string Batch { get; set; }
        public string Course { get; set; }
        public string StudentName { get; set; }
        public string Image { get; set; }
        public List<ActivityClass> DeailsReport { get; set; }
        public List<MedicineActivityClass> MedicineReport { get; set; }
        public List<Holidaydetail> HolidaysReport { get; set; }

        public StudentActivity()
        {
            DeailsReport = new List<ActivityClass>();
            MedicineReport = new List<MedicineActivityClass>();
            HolidaysReport = new List<Holidaydetail>();
        }
    }
    public class ActivityClass
    {
        public string ActivityDate { get; set; }
        public List<ActivityDetails> ActivityDetailsList { get; set; }
        public ActivityClass()
        {
            ActivityDetailsList = new List<ActivityDetails>();
        }
    }

    public class ActivityDetails
    {
        public string ActivityName { get; set; }
        public string WhatActivity { get; set; }
        public string Howmuch { get; set; }
        public string ActivityTime { get; set; }
        public string Comments { get; set; }
        public string BatchName { get; set; }
        public string CourseName { get; set; }
        public string StudentName { get; set; }
        public DateTime? ActivityDate { get; set; }
    }

    public class MedicineActivityClass
    {
        public string ActivityDate { get; set; }
        public List<MedicineReportDetails> MedicineReportDetailsList { get; set; }
        public MedicineActivityClass()
        {
            MedicineReportDetailsList = new List<MedicineReportDetails>();
        }
    }

    public class MedicineReportDetails
    {
        public string MedicineName { get; set; }
        public string UOM { get; set; }
        public string ActivityDate { get; set; }
    }

    public class Holidaydetail
    {
        public string MonthName { get; set; }
        public List<holidayDiscription> ListOfEventsDiscription { get; set; }
        public Holidaydetail()
        {
            ListOfEventsDiscription = new List<holidayDiscription>();
        }
    }
    public class holidayDiscription
    {
        public string Dates { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
