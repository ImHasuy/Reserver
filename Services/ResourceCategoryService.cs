using AutoMapper;
using Reserver.Additional;
using Reserver.DTOs.EquipmentCategory;
using Reserver.DTOs.Location;
using Reserver.DTOs.ResourceCategory;
using Reserver.Entities;
using Reserver.Interfaces;

namespace Reserver.Services;

public class ResourceCategoryService : IResourceCategoryService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    public ResourceCategoryService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<string> CreateResourceCategory(CreateResourceCategoryDto location)
    {
        var temp = _mapper.Map<ResourceCategory>(location);
        await _context.ResourceCategory.AddAsync(temp);
        await _context.SaveChangesAsync();
        return $"Resource Category created with id:  {temp.Id}";
    }
    
}