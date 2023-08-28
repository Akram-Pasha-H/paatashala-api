namespace PaatashalaApi.DTOs
{
    public class Holiday
    {
        public List<days> HolidaysList { get; set; }
        public Holiday()
        {
            HolidaysList = new List<days>();
        }
    }
    public class days
    {
        public string Name { get; set; }
        public string Date { get; set; }
    }
}
