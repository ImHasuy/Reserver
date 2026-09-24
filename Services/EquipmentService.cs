using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Reserver.Additional;
using Reserver.DTOs.Equipment;
using Reserver.DTOs.Reservation;
using Reserver.DTOs.Room;
using Reserver.Entities;
using Reserver.Interfaces;

namespace Reserver.Services;

public class EquipmentService : IEquipmentService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    public EquipmentService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<List<GetEquipmentsDto>> GetEquipments()
    {
        var temp = await _context.Equipment.ToListAsync();
        return _mapper.Map<List<GetEquipmentsDto>>(temp);
    }

    public async Task<List<GetEquipmentDto>> GetAEquipment(Guid id)
    {
        var temp = await _context.Equipment.FirstOrDefaultAsync(k => k.Id == id) ?? throw new Exception("No entry found");
        return _mapper.Map<List<GetEquipmentDto>>(temp);
    }
    
    public async Task<string> CreateEquipment(CreateEquipmentDto room)
    {
        var temp = _mapper.Map<Equipment>(room);
        await _context.Equipment.AddAsync(temp);
        await _context.SaveChangesAsync();
        return $"Location created with id:  {temp.Id}";
    }
    
    
    public async Task<string> UpdateEquipment(UpdateEquipmentDto equipmentDto,Guid id)
    {
        var temp = await _context.Equipment.FirstOrDefaultAsync(k => k.Id == id) ?? throw new Exception("No entry found");
        _mapper.Map(equipmentDto, temp);
        temp.UpdatedAt = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return $"Room {temp.Id} updated";
    }
    
    public async Task<List<GetReservationDtoBrief>> GetReservationsById(Guid id)
    {
        var temp = await _context.Equipment
            .Include(k => k.Reservations)
            .FirstOrDefaultAsync(k => k.Id == id) ?? throw new Exception("No entry found");
        return  _mapper.Map<List<GetReservationDtoBrief>>(temp.Reservations);
    }
    
    public async Task<string> GetEquipmentAvailabilityInTimePeriod(GetEquipmentAvailabilityDto availabilityDto, Guid id)
    {
        var temp = await _context.Equipment
            .Include(k => k.Reservations)
            .FirstOrDefaultAsync(k => k.Id == id) ?? throw new Exception("No entry found");

        var avaliable = temp.Reservations.Any(j =>
            availabilityDto.StartTime < j.EndTime && availabilityDto.EndTime > j.StartTime);

        
        return avaliable ? "The equipment is not available in this time period" : "The equipment is avalaiable in this time period";
    }
}