using AutoMapper;
using Reserver.Additional;
using Reserver.DTOs.Location;
using Reserver.Entities;
using Reserver.Interfaces;

namespace Reserver.Services;

public class LocationService : ILocationService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    public LocationService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<string> CreateLocation(CreateLocationDto location)
    {
        var temp = _mapper.Map<Location>(location);
        await _context.Location.AddAsync(temp);
        await _context.SaveChangesAsync();
        return $"Location created with id:  {temp.Id}";
    }
}