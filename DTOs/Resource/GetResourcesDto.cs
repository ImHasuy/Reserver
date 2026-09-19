using Reserver.Entities.Enums;

namespace Reserver.DTOs.Resource;

public class GetResourcesDto
{
    public Guid Id  { get; set; } 
    
    public string Name { get; set; }
    
    public ResourceTypeEnum ResourceType { get; set; }
    
    public String Category { get; set; }
    
    public String Location { get; set; }

    public Boolean IsActive { get; set; }
    
    public ResourceStatusEnum  Status { get; set; }
    
}