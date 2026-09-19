using Reserver.DTOs.EquipmentCategory;

namespace Reserver.Interfaces;

public interface IEquipmentCategoryService
{
    Task<string> CreateEquipmentCategory(CreateEquipmentCategoryDto EquipmentCategoryDto);
}