using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class HackstreetDbContext : DbContext
{
    public HackstreetDbContext(DbContextOptions<HackstreetDbContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // get from config
        optionsBuilder.UseSqlServer(@"");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Referral> Referrals { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

}
