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
        builder.Entity<Referral>(entity => entity.ToTable("Referral").HasKey(x => x.Id));
        builder.Entity<Appointment>(entity => entity.ToTable("Appointment").HasKey(x => x.Id));
        builder.Entity<Patient>(entity => entity.ToTable("Patient").HasKey(x => x.Id));
        builder.Entity<Employee>(entity => entity.ToTable("Employee").HasKey(x => x.Id));
    }

    public DbSet<Referral> Referrals { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Request> Requests { get; set; }
    public DbSet<Employee> Employees { get; set; }

}
