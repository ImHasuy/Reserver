using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Reserver.Entities.Enums;

namespace Reserver.Entities;

public class Resource
{ 
    [Key,Required]
    public Guid Id  { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Description { get; set; }
    
    public ResourceTypeEnum ResourceType { get; set; }
    
    [ForeignKey("ResourceCategory")]
    public Guid CategoryId { get; set; }
    public ResourceCategory Category { get; set; }
    
    [ForeignKey("Location")]
    public Guid LocationId { get; set; }
    public Location Location { get; set; }
    
    
    public int Capacity { get; set; }
    public Guid? InventoryNumber { get; set; } //Nem teljesen értem de ? kell ide 
    public Boolean IsActive { get; set; }
    
    public ResourceStatusEnum  Status { get; set; }
    
    public List<Reservation> Reservations { get; set; }
    
    public List<MaintenancePeriod> MaintenancePeriods { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public Boolean IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; } //Additional attr
    
}