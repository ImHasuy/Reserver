using Reserver.Entities.Enums;

namespace Reserver.DTOs.Room;

public class GetRoomDto
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
}