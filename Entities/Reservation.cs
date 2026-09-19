using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Reserver.Entities.Enums;

namespace Reserver.Entities;

public class Reservation
{
    [Key,Required]
    public Guid Id { get; set; } =  Guid.NewGuid();
    
    [ForeignKey("Resource")]
    public Guid? ResourceId  { get; set; }
    public Resource? Resource { get; set; }
    
    [ForeignKey("Room")]
    public Guid? RoomId   { get; set; }
    public Room? Room { get; set; }
    
    [ForeignKey("Equipment")]
    public Guid? EquipmentId   { get; set; }
    public Equipment? Equipment { get; set; }
    
    [ForeignKey("ApplicationUser")]
    public Guid UserId { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
    
    
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    
    public ReservationStatusEnum Status { get; set; }
    
    public String Purpose  { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? CancelledAt { get; set; }
    
    public Guid? ReviwerUserId { get; set; }
    
    public DateTime? ApprovedAt { get; set; }
    public DateTime? RejectedAt  { get; set; }
    
    public String Note { get; set; }


}