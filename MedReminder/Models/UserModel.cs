using System.ComponentModel.DataAnnotations;

namespace MedReminder.Models
{
    public class UserModel
    {
        public Guid id { get; } = Guid.NewGuid();

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; };

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
        public string Phone { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime Created { get; set; }

        public List<PrescriptionModel> Prescriptions { get; set; } = new List<PrescriptionModel>();

    }
}
