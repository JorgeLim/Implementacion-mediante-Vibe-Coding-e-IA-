using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/v1/presupuestos")]
public class PresupuestosController : ControllerBase
{
    private readonly IPresupuestoService _presupuestoService;

    public PresupuestosController(IPresupuestoService presupuestoService)
    {
        _presupuestoService = presupuestoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var presupuestos = await _presupuestoService.GetAllAsync();
        return Ok(presupuestos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var presupuesto = await _presupuestoService.GetByIdAsync(id);
        if (presupuesto == null)
            return NotFound(new { Message = "Presupuesto no encontrado" });

        return Ok(presupuesto);
    }
}
