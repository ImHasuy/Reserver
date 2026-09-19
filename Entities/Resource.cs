using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Reserver.Entities.Enums;

namespace Reserver.Entities;

public class Resource
{ 
    [Key,Required]
    public Guid Id  { get; set; } = Guid.NewGuid();
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public ResourceTypeEnum ResourceType { get; set; } 
    
    [ForeignKey("ResourceCategory")]
    public Guid CategoryId { get; set; }
    public ResourceCategory Category { get; set; }
    
    [ForeignKey("Location")]
    public Guid LocationId { get; set; }
    public Location Location { get; set; }
    
    [Required]
    public int Capacity { get; set; }
    public Guid? InventoryNumber { get; set; } = Guid.NewGuid(); //Nem teljesen értem de ? kell ide 
    
    public Boolean IsActive { get; set; } = true;

    public ResourceStatusEnum Status { get; set; } = ResourceStatusEnum.Free;
    
    public List<Reservation>? Reservations { get; set; }
    
    public List<MaintenancePeriod>? MaintenancePeriods { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    
    public Boolean IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; } 
    
}