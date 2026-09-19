using Reserver.Entities.Enums;

namespace Reserver.DTOs.Resource;

public class CreateResourceDTO
{

    public string Name { get; set; }
    public string Description { get; set; }
    public ResourceTypeEnum ResourceType { get; set; }
    public Guid CategoryId { get; set; }
    public Guid LocationId { get; set; }
    public int Capacity { get; set; }
}
