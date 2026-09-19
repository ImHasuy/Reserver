using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reserver.Entities;

public class MaintenancePeriod
{
    [Key,Required]
    public Guid Id { get; set; }
    
    [ForeignKey("Resource")]
    public Guid? ResourceId  { get; set; }
    public Resource? Resource { get; set; }
    
    [ForeignKey("Room")]
    public Guid? RoomId   { get; set; }
    public Room? Room { get; set; }
    
    [ForeignKey("Equipment")]
    public Guid? EquipmentId   { get; set; }
    public Equipment? Equipment { get; set; }
    
    public DateTime StartTime { get; set; }
    public DateTime EndTime  { get; set; }
    
    public String Reason { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public Guid CreatedByUserId  { get; set; }
    
    public Boolean IsActive  { get; set; }
    
}