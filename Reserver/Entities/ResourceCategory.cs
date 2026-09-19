namespace Reserver.Entities;

public class ResourceCategory
{
    public Guid Id { get; set; }
    public String Name { get; set; }
    public String Description { get; set; }
    public Boolean IsActive { get; set; }
}