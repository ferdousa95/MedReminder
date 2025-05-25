namespace MedReminder.Models
{
    public class PrescriptionModel
    {
        public int Id { get; set; }

        public string DoctorName { get; set; }
        public string Notes { get; set; }
        public DateTime PrescribedOn { get; set; }

        // Foreign key + Navigation property
        public int UserId { get; set; }
        public UserModel? User { get; set; }

        // Each prescription can have multiple meds
        public ICollection<MedicationModel> Medications { get; set; } = new List<MedicationModel>();
    }
}
