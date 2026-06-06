using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/v1/areas")]
public class AreasController : ControllerBase
{
    private readonly IAreaService _areaService;

    public AreasController(IAreaService areaService)
    {
        _areaService = areaService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var areas = await _areaService.GetAllAsync();
        return Ok(areas);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var area = await _areaService.GetByIdAsync(id);
        if (area == null)
            return NotFound(new { Message = "Área no encontrada" });

        return Ok(area);
    }
}