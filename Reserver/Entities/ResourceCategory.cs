using System.ComponentModel.DataAnnotations;

namespace Reserver.Entities;

public class ResourceCategory
{
    [Key,Required]
    public Guid Id { get; set; }
    public String Name { get; set; }
    public String Description { get; set; }
    public Boolean IsActive { get; set; }
    
    public List<Resource> Resources { get; set; }
    
}