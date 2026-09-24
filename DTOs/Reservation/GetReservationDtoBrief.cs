namespace Reserver.DTOs.Reservation;

public class GetReservationDtoBrief
{
    public Guid Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime  { get; set; }
    public string Status { get; set; } //needs map
}