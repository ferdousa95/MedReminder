namespace MedReminder.Models
{
    public class MedicationModel
    {
        public int Id { get; set; }

        public string Name { get; set; } // e.g., "Atorvastatin"
        public string Dosage { get; set; } // e.g., "10mg"
        public bool Morning { get; set; }
        public bool Afternoon { get; set; }
        public bool Dinner { get; set; }
        public TimeSpan? TimeOfDay { get; set; } // Optional: for reminder notifications

        public string Notes { get; set; } // Optional

        // Foreign key to Prescription
        public int PrescriptionId { get; set; }
        public PrescriptionModel Prescription { get; set; }
    }
}
