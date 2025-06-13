using kolos2.DTOs;
using kolos2.Service;
using Microsoft.AspNetCore.Mvc;

namespace kolos2.Controllers;


[ApiController]
[Route("api/[controller]")]
public class Controller : ControllerBase
{
    private readonly ITree _service;

        public Controller(ITree service)
        {
            _service = service;
        }

        [HttpGet("{id}/batches")]
        public async Task<IActionResult> GetPlayerMatches(int id)
        {
            try
            {
                var result = await _service.GetTree(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayer(AddTreeDto dto)
        {
            try
            {
                await _service.AddTree(dto);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
}