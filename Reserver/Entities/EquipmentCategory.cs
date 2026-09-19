using System.ComponentModel.DataAnnotations;

namespace Reserver.Entities;

public class EquipmentCategory
{
    [Key,Required]
    public Guid Id { get; set; }
    public String Name { get; set; }
    public List<Equipment> Equipments { get; set; }
}