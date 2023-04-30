using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CPW211_EasyAppointmentManager.Models;

namespace CPW211_EasyAppointmentManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CPW211_EasyAppointmentManager.Models.Customer>? Customer { get; set; }
        public DbSet<CPW211_EasyAppointmentManager.Models.Doctor>? Doctor { get; set; }
        public DbSet<CPW211_EasyAppointmentManager.Models.Specialization>? Specialization { get; set; }
        public DbSet<CPW211_EasyAppointmentManager.Models.Clinic>? Clinic { get; set; }
        public DbSet<CPW211_EasyAppointmentManager.Models.Service>? Service { get; set; }
        public DbSet<CPW211_EasyAppointmentManager.Models.TimeSlot>? TimeSlot { get; set; }
        public DbSet<CPW211_EasyAppointmentManager.Models.Appointment>? Appointment { get; set; }
    }
}