namespace PaatashalaApi.DTOs
{
    public class StudentMedinfo
    {
        public long StudentId { get; set; }
        public string Date { get; set; }
        public long OrgId { get; set; }
        public long MedicineId { get; set; }
        public string Dosage { get; set; }
        public string Time { get; set; }
    }
}
