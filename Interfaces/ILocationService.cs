using Reserver.DTOs.Location;

namespace Reserver.Interfaces;

public interface ILocationService
{
    Task<string> CreateLocation(CreateLocationDto location);
}