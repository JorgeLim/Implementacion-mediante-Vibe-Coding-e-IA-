using Domain.Entities;
using Application.Interfaces;

namespace Infrastructure.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly List<Usuario> _usuarios = new()
    {
        new Usuario 
        { 
            IdUsuario = 1, 
            Nombre = "Juan", 
            ApellidoPaterno = "Pérez", 
            ApellidoMaterno = "López", 
            Correo = "juan.perez@empresa.com", 
            PasswordHash = "hash123", 
            IdRol = 1, 
            IdArea = 1, 
            Activo = true 
        },
        new Usuario 
        { 
            IdUsuario = 2, 
            Nombre = "María", 
            ApellidoPaterno = "García", 
            ApellidoMaterno = "Hernández", 
            Correo = "maria.garcia@empresa.com", 
            PasswordHash = "hash456", 
            IdRol = 2, 
            IdArea = 2, 
            Activo = true 
        }
    };

    public async Task<IEnumerable<Usuario>> GetAllAsync()
    {
        await Task.Delay(10); // Simular async
        return _usuarios;
    }

    public async Task<Usuario?> GetByIdAsync(int id)
    {
        await Task.Delay(10);
        return _usuarios.FirstOrDefault(u => u.IdUsuario == id);
    }
}