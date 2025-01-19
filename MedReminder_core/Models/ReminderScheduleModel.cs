namespace MedReminder_core.Models
{
    public class ReminderScheduleModel
    {
        public int ReminderScheduleId { get; set; }
        public int? PrescriptionId { get; set; }
        public int? MedicationId { get; set; }
        public DateTime ReminderTime { get; set; }
        public int NotifyBefore { get; set; }

        public PrescriptionModel Prescription { get; set; }
        public MedicineModel Medication { get; set; }
    }
}
