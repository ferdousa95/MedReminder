namespace MedReminder_core.Models
{
    public class PrescriptionMedicationModel
    {
        public int PrescriptionId { get; set; }
        public PrescriptionModel Prescription { get; set; }

        public int MedicationId { get; set; }
        public MedicineModel Medication { get; set; }
    }
}
