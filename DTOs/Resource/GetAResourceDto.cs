using Reserver.DTOs.MaintenancePeriod;
using Reserver.DTOs.Reservation;
using Reserver.Entities;
using Reserver.Entities.Enums;

namespace Reserver.DTOs.Resource;

public class GetAResourceDto
{
    public Guid Id  { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public string ResourceType { get; set; } //Needs map
    
    public string Category { get; set; }
    
    public string Location { get; set; }
   
    public int Capacity { get; set; }
    
    public Guid? InventoryNumber { get; set; } 
    
    public Boolean IsActive { get; set; }
    
    public string  Status { get; set; } //Needs map
    
    public List<GetReservationDtoBrief> Reservations { get; set; }  //Needs map
    
    public List<GetMaintenancePeriodsDTOBrief> MaintenancePeriods { get; set; } //Needs map
    
}