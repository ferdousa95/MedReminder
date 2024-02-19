namespace MedReminder.Models
{
    public class Reminder
    {
        public Guid Uuid { get; } = new();
        public bool Morning { get; set; }
        public bool Afternoon { get; set; }
        public bool Evening { get; set; }
    }
}