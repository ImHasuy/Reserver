using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Reserver.Entities.Enums;

namespace Reserver.Entities;

public class Equipment
{
    [Key,Required]
    public Guid Id { get; set; }
    public String Name { get; set; }
    public String Description { get; set; }
    public Guid InventoryNumber  { get; set; }
    
    [ForeignKey("EquipmentCategory")]
    public Guid CategoryId  { get; set; } 
    public EquipmentCategory Category { get; set; }
    
    [ForeignKey("Location")]
    public Guid LocationId { get; set; }
    public Location Location { get; set; }
    
    public Boolean IsPortable { get; set; }
    public Boolean IsActive { get; set; }
    
    public EquipmentStatusEnum Status { get; set; }
    
    public List<Reservation> Reservations { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public Boolean IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; } //Additional attr

}