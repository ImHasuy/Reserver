using Reserver.Entities.Enums;

namespace Reserver.Entities;

public class Reservation
{
    public Guid Id { get; set; }
    
    
    public Guid ResourceId { get; set; }
    public Guid RoomId { get; set; }
    public Guid EquipmentId { get; set; }
    
    
    public Guid UserId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public ReservationStatusEnum Status { get; set; }
    public String Purpose  { get; set; } 
    public DateTime CreatedAt { get; set; }
    public DateTime CancelledAt { get; set; }
    public DateTime ApprovedAt { get; set; }
    public DateTime RejectedAt  { get; set; }
    public String Note { get; set; }


}