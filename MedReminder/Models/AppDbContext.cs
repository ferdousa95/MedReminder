using Microsoft.EntityFrameworkCore;

namespace MedReminder.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<PrescriptionModel> Prescription { get; set; }
        public DbSet<MedicationModel> Medication { get; set; }

    }
}
