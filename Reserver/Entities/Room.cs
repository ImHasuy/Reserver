using Reserver.Entities.Enums;

namespace Reserver.Entities;

public class Room
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public BuildingEnum Building { get; set; }
    public int Floor { get; set; }
    public int RoomNumber { get; set; }
    public int Capacity { get; set; }    
    public string Description { get; set; }
    public Boolean IsActive { get; set; }
    public RoomStatusEnum Status { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public Boolean IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; } //Additional attr
    
}
