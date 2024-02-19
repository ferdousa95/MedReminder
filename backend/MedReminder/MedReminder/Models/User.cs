namespace MedReminder.Models
{
    public class User
    {
        public Guid Uuid { get; } = new();
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string AllAccessRights { get; set; } = "normal";
        private List<Medicine> Medicine { get; set; } = [];

        public void AddMedicine(Medicine medicine)
        {
            Medicine.Add(medicine);
        }

        public void RemoveMedicine(Medicine medicine)
        {
            Medicine.Remove(medicine);
        }

        public void BulkAddMedicine(List<Medicine> medicines)
        {
            BulkAddMedicine(medicines.ToArray());
        }

        public void BulkAddMedicine(IEnumerable<Medicine> medicines)
        {
            Medicine.AddRange(medicines);
        }

    }

    public class NormalUser : User
    {
        private NormalUser()
        {
            AllAccessRights = "normal";
        }

        public NormalUser(string firstName, string lastName, string age) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Age = int.Parse(age);
        }
    }

    public class AdminUser : User
    {
        private AdminUser()
        {
            AllAccessRights = "admin";
        }
    }
}