using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services;

public class CentroCostoService : ICentroCostoService
{
    private readonly ICentroCostoRepository _repository;

    public CentroCostoService(ICentroCostoRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CentroCostoDto>> GetAllAsync()
    {
        var centros = await _repository.GetAllAsync();
        return centros.Select(c => new CentroCostoDto
        {
            IdCentroCosto = c.IdCentroCosto,
            Nombre = c.Nombre,
            Descripcion = c.Descripcion,
            IdArea = c.IdArea,
            Activo = c.Activo,
            FechaCreacion = c.FechaCreacion,
            FechaActualizacion = c.FechaActualizacion
        });
    }

    public async Task<CentroCostoDto?> GetByIdAsync(int id)
    {
        var centro = await _repository.GetByIdAsync(id);
        if (centro == null) return null;

        return new CentroCostoDto
        {
            IdCentroCosto = centro.IdCentroCosto,
            Nombre = centro.Nombre,
            Descripcion = centro.Descripcion,
            IdArea = centro.IdArea,
            Activo = centro.Activo,
            FechaCreacion = centro.FechaCreacion,
            FechaActualizacion = centro.FechaActualizacion
        };
    }
}