using Microsoft.AspNetCore.Mvc;
using Reserver.Additional;
using Reserver.DTOs.EquipmentCategory;
using Reserver.Interfaces;

namespace Reserver.Controllers;


[ApiController]
[Route("api/[Controller]")]
public class EquipmentCategoryController : ControllerBase
{
    private readonly IEquipmentCategoryService _equipmentCategoryService;

    public EquipmentCategoryController(IEquipmentCategoryService equipmentCategoryService)
    {
        _equipmentCategoryService = equipmentCategoryService;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateEquipmentCategory(CreateEquipmentCategoryDto createEquipmentCategoryDto)
    {
        ApiResponse apiResponse = new ApiResponse();
        try
        {
            apiResponse.Data = await _equipmentCategoryService.CreateEquipmentCategory(createEquipmentCategoryDto);
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
