namespace Reserver.DTOs.ResourceCategory;

public class CreateResourceCategoryDto
{
    public String Name { get; set; }
    public String Description { get; set; }
    public Boolean IsActive { get; set; }
}