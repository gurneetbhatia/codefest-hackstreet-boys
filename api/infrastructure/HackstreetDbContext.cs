using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class HackstreetDbContext : DbContext
{
    public HackstreetDbContext(DbContextOptions<HackstreetDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Referral>(entity => entity.ToTable("Referrals"));
        builder.Entity<Appointment>(entity => entity.ToTable("Appointments"));
        builder.Entity<Patient>(entity => entity.ToTable("Patients"));
        builder.Entity<Employee>(entity => entity.ToTable("Employees"));
    }

    public DbSet<Referral> Referrals { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Employee> Employee { get; set; }

}
