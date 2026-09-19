using Reserver.Entities.Enums;

namespace Reserver.DTOs.Location;

public class CreateLocationDto
{
    public String Name { get; set; }
    public String Address { get; set; }
    
    public BuildingEnum Building  { get; set; }
    
    public int Floor { get; set; }
    
    public String Description { get; set; }

}