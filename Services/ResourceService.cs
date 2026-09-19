using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Reserver.Additional;
using Reserver.DTOs.Resource;
using Reserver.Entities;
using Reserver.Interfaces;

namespace Reserver.Services;

public class ResourceService : IResourceService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    public ResourceService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<List<GetResourcesDto>> ListReources()
    {
        var temp = await _context.Resource
            .Include(x => x.Category)
            .Include(k => k.Location)
            .ToListAsync();
        return _mapper.Map<List<GetResourcesDto>>(temp);
    }

    public async Task<GetAResourceDto> ShowResource(Guid id)
    {
        var temp = await _context.Resource
            .Include(x => x.Category)
            .Include(k => k.Location)
            .FirstOrDefaultAsync(k => k.Id == id);
        return _mapper.Map<GetAResourceDto>(temp);
    }

    public async Task<string> CreateResource(CreateResourceDTO resource)
    {
        var temp = _mapper.Map<Resource>(resource);
        
        await _context.Resource.AddAsync(temp);
        await _context.SaveChangesAsync();
        return $"Resource {temp.Id} created";
    }

    public async Task<string> UpdateResource(UpdateResourcesDto  resource, Guid id)
    {
        var temp = await _context.Resource.FirstOrDefaultAsync(k=>k.Id == id) ?? throw new Exception("No entry found");
        _mapper.Map(resource, temp);
        temp.UpdatedAt =  DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return $"Resource {temp.Id} updated";
    }

    public async Task<string> DeactivateResource(Guid id)
    {
        var temp = await _context.Resource.FirstOrDefaultAsync(k => k.Id == id) ?? throw new Exception("No entry found");
        temp.IsActive =  false;
        temp.UpdatedAt = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return $"Resource {temp.Id} deactivated";
    }

    public async Task<string> ActivateResource(Guid id)
    {
        var temp = await _context.Resource.FirstOrDefaultAsync(k => k.Id == id) ?? throw new Exception("No entry found");
        temp.IsActive =  true;
        temp.UpdatedAt = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return $"Resource {temp.Id} activated";
    }
}