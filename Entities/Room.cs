using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Reserver.Entities.Enums;

namespace Reserver.Entities;

public class Room
{
    [Key,Required]
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    
    public BuildingEnum Building { get; set; }
    public int Floor { get; set; }
    public int RoomNumber { get; set; }
    
    public int Capacity { get; set; }
    
    public string Description { get; set; }
    
    public Boolean IsActive { get; set; }
    
    public RoomStatusEnum Status { get; set; }
    
    public List<Reservation> Reservations { get; set; }
    
    public List<MaintenancePeriod> MaintenancePeriods { get; set; }
    
    public Location  Location { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    
    public Boolean IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; } 
    
}
