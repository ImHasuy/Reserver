using AutoMapper;
using Reserver.Additional;
using Reserver.DTOs.EquipmentCategory;
using Reserver.Entities;
using Reserver.Interfaces;

namespace Reserver.Services;

public class EquipmentCategoryService : IEquipmentCategoryService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    public EquipmentCategoryService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<string> CreateEquipmentCategory(CreateEquipmentCategoryDto EquipmentCategoryDto)
    {
        var temp = _mapper.Map<EquipmentCategory>(EquipmentCategoryDto);
        await _context.EquipmentCategory.AddAsync(temp);
        await _context.SaveChangesAsync();
        return $"Equipment category {temp.Id} created";
    }
}