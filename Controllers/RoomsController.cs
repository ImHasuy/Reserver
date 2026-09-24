using Microsoft.AspNetCore.Mvc;
using Reserver.Additional;
using Reserver.DTOs.Room;
using Reserver.Interfaces;

namespace Reserver.Controllers;



[ApiController]
[Route("api/[Controller]")]
public class RoomsController : ControllerBase
{
    private readonly IRoomService _roomService;

    public RoomsController(IRoomService roomService)
    {
        _roomService = roomService;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateRoom(CreateRoomDto createRoomDto)
    {
        ApiResponse apiResponse = new ApiResponse();
        try
        {
            apiResponse.Data = await _roomService.CreateRoom(createRoomDto);
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
    public async Task<IActionResult> GetRooms()
    {
        ApiResponse apiResponse = new ApiResponse();
        try
        {
            apiResponse.Data = await _roomService.GetRooms();
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
    public async Task<IActionResult> GetARoom(Guid id)

    {
        ApiResponse apiResponse = new ApiResponse();
        try
        {
            apiResponse.Data = await _roomService.GetARoom(id);
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
    public async Task<IActionResult> UpdateRoom(UpdateRoomDto roomDto, Guid id)
    {
        ApiResponse apiResponse = new ApiResponse();
        try
        {
            apiResponse.Data = await _roomService.UpdateRoom(roomDto, id);
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
            apiResponse.Data = await _roomService. GetReservationsById(id);
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
    public async Task<IActionResult> GetRoomAvailabilityInTimePeriod(GetRoomAvaliabilityDto availabilityDto, Guid id)
    {
        ApiResponse apiResponse = new ApiResponse();
        try
        {
            apiResponse.Data = await _roomService.GetRoomAvailabilityInTimePeriod( availabilityDto, id);
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