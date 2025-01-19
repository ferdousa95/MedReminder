namespace MedReminder_core.Models
{
    public class MedicationInventoryModel
    {
        public int InventoryId { get; set; }
        public int MedicationId { get; set; }
        public MedicineModel Medication { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
