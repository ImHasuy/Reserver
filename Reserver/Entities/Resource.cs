using System.ComponentModel.DataAnnotations;
using Reserver.Entities.Enums;

namespace Reserver.Entities;

public class Resource
{ 
    [Key,Required]
    public Guid Id  { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Description { get; set; }
    
    public ResourceTypeEnum ResourceType { get; set; }
    
    public Guid CategoryId { get; set; }
    
    public Guid LocationId { get; set; }
    
    public int Capacity { get; set; }
    public Guid? InventoryNumber { get; set; } //Nem teljesen értem de ? kell ide 
    public Boolean IsActive { get; set; }
    
    public ResourceStatusEnum  Status { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public Boolean IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; } //Additional attr
    
}