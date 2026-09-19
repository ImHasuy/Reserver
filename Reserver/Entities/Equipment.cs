using Reserver.Entities.Enums;

namespace Reserver.Entities;

public class Equipment
{
    public Guid Id { get; set; }
    public String Name { get; set; }
    public String Description { get; set; }
    public Guid InventoryNumber  { get; set; }
    public Guid CategoryId  { get; set; }
    public Guid LocationId { get; set; }
    public Boolean IsPortable { get; set; }
    public Boolean IsActive { get; set; }
    public EquipmentStatusEnum Status { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public Boolean IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; } //Additional attr

}