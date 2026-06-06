using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services;

public class RolService : IRolService
{
    private readonly IRolRepository _repository;

    public RolService(IRolRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<RolDto>> GetAllAsync()
    {
        var roles = await _repository.GetAllAsync();
        return roles.Select(r => new RolDto
        {
            IdRol = r.IdRol,
            Nombre = r.Nombre,
            Descripcion = r.Descripcion,
            Activo = r.Activo,
            FechaCreacion = r.FechaCreacion,
            FechaActualizacion = r.FechaActualizacion
        });
    }

    public async Task<RolDto?> GetByIdAsync(int id)
    {
        var rol = await _repository.GetByIdAsync(id);
        if (rol == null) return null;

        return new RolDto
        {
            IdRol = rol.IdRol,
            Nombre = rol.Nombre,
            Descripcion = rol.Descripcion,
            Activo = rol.Activo,
            FechaCreacion = rol.FechaCreacion,
            FechaActualizacion = rol.FechaActualizacion
        };
    }
}