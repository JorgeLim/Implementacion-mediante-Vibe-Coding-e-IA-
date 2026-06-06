using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services;

public class AreaService : IAreaService
{
    private readonly IAreaRepository _repository;

    public AreaService(IAreaRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<AreaDto>> GetAllAsync()
    {
        var areas = await _repository.GetAllAsync();
        return areas.Select(a => new AreaDto
        {
            IdArea = a.IdArea,
            Nombre = a.Nombre,
            Descripcion = a.Descripcion,
            Activo = a.Activo,
            FechaCreacion = a.FechaCreacion,
            FechaActualizacion = a.FechaActualizacion
        });
    }

    public async Task<AreaDto?> GetByIdAsync(int id)
    {
        var area = await _repository.GetByIdAsync(id);
        if (area == null) return null;

        return new AreaDto
        {
            IdArea = area.IdArea,
            Nombre = area.Nombre,
            Descripcion = area.Descripcion,
            Activo = area.Activo,
            FechaCreacion = area.FechaCreacion,
            FechaActualizacion = area.FechaActualizacion
        };
    }
}