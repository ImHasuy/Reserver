using Reserver.DTOs.ResourceCategory;

namespace Reserver.Interfaces;

public interface IResourceCategoryService
{
    Task<string> CreateResourceCategory(CreateResourceCategoryDto location);
}