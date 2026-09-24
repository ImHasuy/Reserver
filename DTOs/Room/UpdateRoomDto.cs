using Reserver.Entities.Enums;

namespace Reserver.DTOs.Room;

public class UpdateRoomDto
{
    public string? Name { get; set; }
    public int? Capacity { get; set; }
    public string? Description { get; set; }
    public Boolean? IsActive { get; set; }
    public RoomStatusEnum? Status { get; set; }
}