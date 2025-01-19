namespace MedReminder_core.Models
{
    public class NotificationModel
    {
        public int NotificationId { get; set; }
        public int? PrescriptionId { get; set; }
        public int? MedicationId { get; set; }
        public string Message { get; set; }
        public DateTime SentDate { get; set; }

        public PrescriptionModel Prescription { get; set; }
        public MedicineModel Medication { get; set; }
    }
}
