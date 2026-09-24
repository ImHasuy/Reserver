using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Reserver.Additional;
using Reserver.DTOs.Location;
using Reserver.DTOs.Reservation;
using Reserver.DTOs.Room;
using Reserver.Entities;
using Reserver.Interfaces;

namespace Reserver.Services;

public class RoomService : IRoomService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    public RoomService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<string> CreateRoom(CreateRoomDto room)
    {
        var temp = _mapper.Map<Room>(room);
        await _context.Room.AddAsync(temp);
        await _context.SaveChangesAsync();
        return $"Location created with id:  {temp.Id}";
    }
    
    public async Task<List<GetRoomsDto>> GetRooms()
    {
        var temp = await _context.Room.ToListAsync();
        return _mapper.Map<List<GetRoomsDto>>(temp);
    }

    public async Task<List<GetRoomDto>> GetARoom(Guid id)
    {
        var temp = await _context.Room.FirstOrDefaultAsync(k => k.Id == id) ?? throw new Exception("No entry found");
        return _mapper.Map<List<GetRoomDto>>(temp);
    }

    public async Task<string> UpdateRoom(UpdateRoomDto roomDto,Guid id)
    {
        var temp = await _context.Room.FirstOrDefaultAsync(k => k.Id == id) ?? throw new Exception("No entry found");
        _mapper.Map(roomDto, temp);
        temp.UpdatedAt = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return $"Room {temp.Id} updated";
    }
    
    public async Task<List<GetReservationDtoBrief>> GetReservationsById(Guid id)
    {
        var temp = await _context.Room
            .Include(k => k.Reservations)
            .FirstOrDefaultAsync(k => k.Id == id) ?? throw new Exception("No entry found");
        return  _mapper.Map<List<GetReservationDtoBrief>>(temp.Reservations);
    }
    
    public async Task<string> GetRoomAvailabilityInTimePeriod(GetRoomAvaliabilityDto availabilityDto ,Guid id)
    {
        var temp = await _context.Room
            .Include(k => k.Reservations)
            .FirstOrDefaultAsync(k => k.Id == id) ?? throw new Exception("No entry found");

        var avaliable = temp.Reservations.Any(j =>
            availabilityDto.StartTime < j.EndTime && availabilityDto.EndTime > j.StartTime);

        
        return avaliable ? "The room is not available in this time period" : "The room is avalaiable in this time period";
    }




    
    
}