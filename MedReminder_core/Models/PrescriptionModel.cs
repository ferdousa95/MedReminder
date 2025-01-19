namespace MedReminder_core.Models
{
    public class PrescriptionModel
    {
        public Guid PrescriptionId { get; } = Guid.NewGuid();
        public int UserId { get; set; }
        public UserModel User { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public ICollection<PrescriptionMedicationModel> PrescriptionMedications { get; set; }
    }
}
