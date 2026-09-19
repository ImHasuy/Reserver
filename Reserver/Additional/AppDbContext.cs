using Microsoft.EntityFrameworkCore;

namespace Reserver.Additional;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    //public DbSet<Admin> Admins { get; set; }


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

