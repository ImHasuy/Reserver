using Microsoft.AspNetCore.Mvc;
using Reserver.Additional;
using Reserver.DTOs.ResourceCategory;
using Reserver.Interfaces;

namespace Reserver.Controllers;


[ApiController]
[Route("api/[Controller]")]
public class ResourceCategoryController : ControllerBase
{
    private readonly IResourceCategoryService _resourceCategoryService;

    public ResourceCategoryController(IResourceCategoryService resourceCategoryService)
    {
        _resourceCategoryService = resourceCategoryService;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateResourceCategory(CreateResourceCategoryDto createResourceDto)
    {
        ApiResponse apiResponse = new ApiResponse();
        try
        {
            apiResponse.Data = await _resourceCategoryService.CreateResourceCategory(createResourceDto);
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