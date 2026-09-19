using Microsoft.EntityFrameworkCore;
using Reserver.Entities;

namespace Reserver.Additional;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<ApplicationUser> ApplicationUser { get; set; }
    public DbSet<Equipment> Equipment { get; set; }
    public DbSet<EquipmentCategory> EquipmentCategory { get; set; }
    public DbSet<Location> Location { get; set; }
    public DbSet<MaintenancePeriod> MaintenancePeriod { get; set; }
    public DbSet<Reservation> Reservation { get; set; }
    public DbSet<Resource> Resource { get; set; }
    public DbSet<ResourceCategory> ResourceCategory { get; set; }
    public DbSet<Room> Room { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        //User entity configuration
        /*
        modelBuilder.Entity<User>()
            .HasOne(u => u.Wallet)
            .WithOne(w => w.User)
            .HasForeignKey<Wallet>(f => f.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        */
        
    }
    
    
}

