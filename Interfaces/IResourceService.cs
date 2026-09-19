using Reserver.DTOs.Resource;

namespace Reserver.Interfaces;

public interface IResourceService
{
    Task<List<GetResourcesDto>> ListReources();
    Task<GetAResourceDto> ShowResource(Guid id);
    Task<string> CreateResource(CreateResourceDTO resource);
    Task<string> UpdateResource(UpdateResourcesDto resourcesDto, Guid id);
    Task<string> DeactivateResource(Guid id);
    Task<string> ActivateResource(Guid id);
    
}