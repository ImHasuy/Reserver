using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Reserver.Additional;
using Reserver.DTOs.Location;
using Reserver.Interfaces;

namespace Reserver.Services;

public class RoomService : ILocationService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    public RoomService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<string> CreateLocation(CreateRoomDto room)
    {
        var temp = _mapper.Map<Room>(location);
        await _context.Room.AddAsync(temp);
        await _context.SaveChangesAsync();
        return $"Location created with id:  {temp.Id}";
    }
    
    public async Task<string> GetRooms()
    {
        var temp = await _context.Location.ToListAsync();
        return _mapper.Map<GetRoomsDto>(temp);
    }

    
}