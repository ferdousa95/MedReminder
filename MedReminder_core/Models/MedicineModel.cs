namespace MedReminder_core.Models
{
    public class MedicineModel
    {
        public Guid MedicationId { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public DateTime ReminderTime { get; set; }

        public ICollection<PrescriptionMedicationModel> PrescriptionMedications { get; set; }
        public MedicationInventoryModel MedicationInventory { get; set; }
    }
}
