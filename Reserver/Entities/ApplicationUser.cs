using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace Reserver.Entities;

[Index(nameof(Email),IsUnique = false)]
[Index(nameof(Name),IsUnique = false)]
public class ApplicationUser
{
    [Key,Required]
    public Guid Id { get; set; }
    public String Name { get; set; }
    public String Email  { get; set; }
    
    public String Password { get; set; }
    
    public List<Reservation> Reservations { get; set; }

}