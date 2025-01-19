namespace MedReminder_core.Models
{
    public class UserModel
    {
        public Guid UserId { get;} = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<PrescriptionModel>? Prescriptions { get; set; }
        public ICollection<NotificationModel> Notifications { get; set; }
        public ICollection<ReminderScheduleModel> ReminderSchedules { get; set; }
    }
}
