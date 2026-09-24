using Reserver.DTOs.Reservation;
using Reserver.DTOs.Room;

namespace Reserver.Interfaces;

public interface IRoomService
{
    Task<string> CreateRoom(CreateRoomDto room);
    Task<List<GetRoomsDto>> GetRooms();
    Task<List<GetRoomDto>> GetARoom(Guid id);

    Task<string> UpdateRoom(UpdateRoomDto roomDto, Guid id);

    Task<List<GetReservationDtoBrief>> GetReservationsById(Guid id);

    Task<string> GetRoomAvailabilityInTimePeriod(GetRoomAvaliabilityDto availabilityDto, Guid id);
}