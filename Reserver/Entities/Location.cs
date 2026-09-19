using System.ComponentModel.DataAnnotations;
using Reserver.Entities.Enums;

namespace Reserver.Entities;

public class Location
{
    [Key,Required]
    public Guid Id { get; set; }
    public String Name { get; set; }
    public String Address { get; set; }
    
    public BuildingEnum Building  { get; set; }
    
    public int Floor { get; set; }
    
    public String Description { get; set; }
    
    public Boolean IsActive { get; set; }    
    
    public List<Resource> Resources { get; set; }
}