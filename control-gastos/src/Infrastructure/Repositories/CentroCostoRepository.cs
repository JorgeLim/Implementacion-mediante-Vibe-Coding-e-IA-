using Domain.Entities;
using Application.Interfaces;

namespace Infrastructure.Repositories;

public class CentroCostoRepository : ICentroCostoRepository
{
    private readonly List<CentroCosto> _centros = new()
    {
        new CentroCosto { IdCentroCosto = 1, Nombre = "Marketing Digital", Descripcion = "Publicidad y campañas", IdArea = 1, Activo = true },
        new CentroCosto { IdCentroCosto = 2, Nombre = "Desarrollo de Software", Descripcion = "Equipo técnico", IdArea = 3, Activo = true },
        new CentroCosto { IdCentroCosto = 3, Nombre = "Contabilidad", Descripcion = "Gestión financiera", IdArea = 1, Activo = true }
    };

    public async Task<IEnumerable<CentroCosto>> GetAllAsync()
    {
        await Task.Delay(10);
        return _centros;
    }

    public async Task<CentroCosto?> GetByIdAsync(int id)
    {
        await Task.Delay(10);
        return _centros.FirstOrDefault(c => c.IdCentroCosto == id);
    }
}