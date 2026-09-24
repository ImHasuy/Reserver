using Microsoft.AspNetCore.Mvc;
using Reserver.Additional;
using Reserver.DTOs.Equipment;
using Reserver.Interfaces;

namespace Reserver.Controllers;



[ApiController]
[Route("api/[Controller]")]
public class EquipmentController : ControllerBase
{
    private readonly IEquipmentService _equipmentService;

    public EquipmentController(IEquipmentService equipmentService)
    {
        _equipmentService = equipmentService;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateResource(CreateEquipmentDto createEquipmentDto)
    {
        ApiResponse apiResponse = new ApiResponse();
        try
        {
            apiResponse.Data = await _equipmentService.CreateEquipment(createEquipmentDto);
            return Ok(apiResponse);
        }
        catch (Exception e)
        {
            apiResponse.StatusCode = 400;
            apiResponse.Message = e.Message;
        }
        return BadRequest(apiResponse);
    }
    
    [HttpGet]
    public async Task<IActionResult> ListReources()
    {
        ApiResponse apiResponse = new ApiResponse();
        try
        {
            apiResponse.Data = await _equipmentService.GetEquipments();
            return Ok(apiResponse);
        }
        catch (Exception e)
        {
            apiResponse.StatusCode = 400;
            apiResponse.Message = e.Message;
        }
        return BadRequest(apiResponse);
    }


    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetAEquipment(Guid id)
    {
        ApiResponse apiResponse = new ApiResponse();
        try
        {
            apiResponse.Data = await _equipmentService.GetAEquipment(id);
            return Ok(apiResponse);
        }
        catch (Exception e)
        {
            apiResponse.StatusCode = 400;
            apiResponse.Message = e.Message;
        }
        return BadRequest(apiResponse);
    }
    
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateResource(Guid id ,UpdateEquipmentDto equipmentDto)
    {
        ApiResponse apiResponse = new ApiResponse();
        try
        {
            apiResponse.Data = await _equipmentService.UpdateEquipment(equipmentDto, id);
            return Ok(apiResponse);
        }
        catch (Exception e)
        {
            apiResponse.StatusCode = 400;
            apiResponse.Message = e.Message;
        }
        return BadRequest(apiResponse);
    }
    
    
    [HttpGet("{id:guid}/reservations")]
    public async Task<IActionResult>  GetReservationsById(Guid id)
    {
        ApiResponse apiResponse = new ApiResponse();
        try
        {
            apiResponse.Data = await _equipmentService. GetReservationsById(id);
            return Ok(apiResponse);
        }
        catch (Exception e)
        {
            apiResponse.StatusCode = 400;
            apiResponse.Message = e.Message;
        }
        return BadRequest(apiResponse);
    }
          
    [HttpGet("{id:guid}/availability")]
    public async Task<IActionResult> GetEquipmentAvailabilityInTimePeriod(GetEquipmentAvailabilityDto availabilityDto, Guid id)
    {
        ApiResponse apiResponse = new ApiResponse();
        try
        {
            apiResponse.Data = await _equipmentService.GetEquipmentAvailabilityInTimePeriod( availabilityDto, id);
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