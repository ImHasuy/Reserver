using Reserver.Entities.Enums;

namespace Reserver.DTOs.Equipment;

public class CreateEquipmentDto
{
    public String Name { get; set; }
    public String Description { get; set; }
    public Guid InventoryNumber { get; set; }

    public Guid CategoryId { get; set; }

    public Guid LocationId { get; set; }

    public Boolean IsPortable { get; set; }
    public Boolean IsActive { get; set; }

    public EquipmentStatusEnum Status { get; set; }
}