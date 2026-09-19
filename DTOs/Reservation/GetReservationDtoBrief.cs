namespace Reserver.DTOs.Reservation;

public class GetReservationDtoBrief
{
    public Guid Id { get; set; }
    public DateTime ApprovedAt { get; set; }
    public DateTime RejectedAt  { get; set; }
    public string Status { get; set; } //needs map

    
}