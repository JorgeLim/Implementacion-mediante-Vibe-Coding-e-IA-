using Microsoft.AspNetCore.Mvc;
using Presentation.Responses;   // ← Este using debe coincidir

namespace Presentation.Controllers;

[ApiController]
[Route("api/v1/{module}")]
public class ApiController : ControllerBase
{
    [HttpGet]
    public IActionResult Get(string module)
    {
        return Ok(ApiResponse.Ok($"Módulo '{module}' disponible."));
    }

    [HttpPost]
    public IActionResult Post(string module, [FromBody] object? data)
    {
        return Ok(ApiResponse.Ok($"Datos recibidos en módulo '{module}'", data));
    }

    [HttpPut]
    public IActionResult Put(string module, [FromBody] object? data)
    {
        return Ok(ApiResponse.Ok($"Actualización recibida en módulo '{module}'", data));
    }

    [HttpDelete]
    public IActionResult Delete(string module)
    {
        return Ok(ApiResponse.Ok($"Eliminación procesada en módulo '{module}'"));
    }
}