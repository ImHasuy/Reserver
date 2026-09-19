namespace Reserver.Entities;

public class MaintenancePeriod
{
    public Guid Id { get; set; }
    
    public Guid ResourceId  { get; set; }
    public Guid RoomId   { get; set; }
    public Guid EquipmentId   { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime  { get; set; }
    public String Reason { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid CreatedByUserId  { get; set; }
    public Boolean IsActive  { get; set; }
    
}