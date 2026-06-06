using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _repository;

    public UsuarioService(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<UsuarioDto>> GetAllAsync()
    {
        var usuarios = await _repository.GetAllAsync();
        return usuarios.Select(u => new UsuarioDto
        {
            IdUsuario = u.IdUsuario,
            Nombre = u.Nombre,
            ApellidoPaterno = u.ApellidoPaterno,
            ApellidoMaterno = u.ApellidoMaterno,
            Correo = u.Correo,
            IdRol = u.IdRol,
            IdArea = u.IdArea,
            Activo = u.Activo,
            FechaCreacion = u.FechaCreacion,
            FechaActualizacion = u.FechaActualizacion
        });
    }

    public async Task<UsuarioDto?> GetByIdAsync(int id)
    {
        var usuario = await _repository.GetByIdAsync(id);
        if (usuario == null) return null;

        return new UsuarioDto
        {
            IdUsuario = usuario.IdUsuario,
            Nombre = usuario.Nombre,
            ApellidoPaterno = usuario.ApellidoPaterno,
            ApellidoMaterno = usuario.ApellidoMaterno,
            Correo = usuario.Correo,
            IdRol = usuario.IdRol,
            IdArea = usuario.IdArea,
            Activo = usuario.Activo,
            FechaCreacion = usuario.FechaCreacion,
            FechaActualizacion = usuario.FechaActualizacion
        };
    }
}