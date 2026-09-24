using Reserver.DTOs.Equipment;
using Reserver.DTOs.Reservation;
using Reserver.DTOs.Room;

namespace Reserver.Interfaces;

public interface IEquipmentService
{
    Task<List<GetEquipmentsDto>> GetEquipments();
    Task<List<GetEquipmentDto>> GetAEquipment(Guid id);
    Task<string> CreateEquipment(CreateEquipmentDto room);
    Task<string> UpdateEquipment(UpdateEquipmentDto equipmentDto, Guid id);
    Task<List<GetReservationDtoBrief>> GetReservationsById(Guid id);
    Task<string> GetEquipmentAvailabilityInTimePeriod(GetEquipmentAvailabilityDto availabilityDto, Guid id);
}