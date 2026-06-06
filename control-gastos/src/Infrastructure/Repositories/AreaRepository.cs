using Domain.Entities;
using Application.Interfaces;

namespace Infrastructure.Repositories;

public class AreaRepository : IAreaRepository
{
    private readonly List<Area> _areas = new()
    {
        new Area { IdArea = 1, Nombre = "Finanzas", Descripcion = "Departamento de Finanzas y Contabilidad", Activo = true },
        new Area { IdArea = 2, Nombre = "Recursos Humanos", Descripcion = "Gestión de personal", Activo = true },
        new Area { IdArea = 3, Nombre = "TI", Descripcion = "Tecnología de la Información", Activo = true }
    };

    public async Task<IEnumerable<Area>> GetAllAsync()
    {
        await Task.Delay(10);
        return _areas;
    }

    public async Task<Area?> GetByIdAsync(int id)
    {
        await Task.Delay(10);
        return _areas.FirstOrDefault(a => a.IdArea == id);
    }
}