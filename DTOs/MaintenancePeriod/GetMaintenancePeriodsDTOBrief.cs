namespace Reserver.DTOs.MaintenancePeriod;

public class GetMaintenancePeriodsDTOBrief
{
    public Guid Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime  { get; set; }
    public String Reason { get; set; }
    public Boolean IsActive  { get; set; }

}