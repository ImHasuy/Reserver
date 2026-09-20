using Microsoft.AspNetCore.Mvc;
using Reserver.Additional;
using Reserver.DTOs.Location;
using Reserver.Interfaces;

namespace Reserver.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class LocationController : ControllerBase
{
    private readonly ILocationService _locationService;

    public LocationController(ILocationService locationService)
    {
        _locationService = locationService;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateLocation(CreateLocationDto createResourceDto)
    {
        ApiResponse apiResponse = new ApiResponse();
        try
        {
            apiResponse.Data = await _locationService.CreateLocation(createResourceDto);
            return Ok(apiResponse);
        }
        catch (Exception e)
        {
            apiResponse.StatusCode = 400;
            apiResponse.Message = e.Message;
        }
        return BadRequest(apiResponse);
    }
}