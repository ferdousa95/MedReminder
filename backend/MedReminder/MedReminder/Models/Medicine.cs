namespace MedReminder.Models
{
    public class Medicine
    {
        public Guid Uuid { get; } = new();
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Reminder? Timetable { get; set; }

        private Medicine() {
            var reminder = new Reminder();
            Timetable = reminder;
        }
    }
}