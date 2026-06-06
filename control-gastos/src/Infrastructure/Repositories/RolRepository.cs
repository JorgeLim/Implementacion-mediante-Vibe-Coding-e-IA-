using Domain.Entities;
using Application.Interfaces;

namespace Infrastructure.Repositories;

public class RolRepository : IRolRepository
{
    private readonly List<Rol> _roles = new()
    {
        new Rol { IdRol = 1, Nombre = "Administrador", Descripcion = "Acceso total al sistema", Activo = true },
        new Rol { IdRol = 2, Nombre = "Gerente", Descripcion = "Gestión de áreas y presupuestos", Activo = true },
        new Rol { IdRol = 3, Nombre = "Empleado", Descripcion = "Registro de gastos", Activo = true }
    };

    public async Task<IEnumerable<Rol>> GetAllAsync()
    {
        await Task.Delay(10);
        return _roles;
    }

    public async Task<Rol?> GetByIdAsync(int id)
    {
        await Task.Delay(10);
        return _roles.FirstOrDefault(r => r.IdRol == id);
    }
}