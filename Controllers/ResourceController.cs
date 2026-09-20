using Microsoft.AspNetCore.Mvc;
using Reserver.Additional;
using Reserver.DTOs.Resource;
using Reserver.Interfaces;

namespace Reserver.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class ResourceController : ControllerBase
{
    private readonly IResourceService _resourceService;

    public ResourceController(IResourceService resourceService)
    {
        _resourceService = resourceService;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateResource(CreateResourceDTO createResourceDto)
    {
        ApiResponse apiResponse = new ApiResponse();
        try
        {
            apiResponse.Data = await _resourceService.CreateResource(createResourceDto);
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