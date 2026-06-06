using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/v1/centroscosto")]
public class CentrosCostoController : ControllerBase
{
    private readonly ICentroCostoService _centroCostoService;

    public CentrosCostoController(ICentroCostoService centroCostoService)
    {
        _centroCostoService = centroCostoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var centros = await _centroCostoService.GetAllAsync();
        return Ok(centros);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var centro = await _centroCostoService.GetByIdAsync(id);
        if (centro == null)
            return NotFound(new { Message = "Centro de costo no encontrado" });

        return Ok(centro);
    }
}