using Domain.Entities;
using Application.Interfaces;

namespace Infrastructure.Repositories;

public class PresupuestoRepository : IPresupuestoRepository
{
    private readonly List<Presupuesto> _presupuestos = new()
    {
        new Presupuesto 
        { 
            IdPresupuesto = 1, 
            IdArea = 1, 
            IdCentroCosto = 1, 
            Periodo = "2026-06", 
            MontoTotal = 50000m, 
            MontoUtilizado = 15000m, 
            FechaInicio = new DateTime(2026, 6, 1), 
            FechaFin = new DateTime(2026, 6, 30), 
            Activo = true,
            FechaCreacion = DateTime.UtcNow
        },
        new Presupuesto 
        { 
            IdPresupuesto = 2, 
            IdArea = 3, 
            IdCentroCosto = 2, 
            Periodo = "2026-06", 
            MontoTotal = 120000m, 
            MontoUtilizado = 45000m, 
            FechaInicio = new DateTime(2026, 6, 1), 
            FechaFin = new DateTime(2026, 6, 30), 
            Activo = true,
            FechaCreacion = DateTime.UtcNow
        },
        new Presupuesto 
        { 
            IdPresupuesto = 3, 
            IdArea = 1, 
            IdCentroCosto = 3, 
            Periodo = "2026-07", 
            MontoTotal = 60000m, 
            MontoUtilizado = 0m, 
            FechaInicio = new DateTime(2026, 7, 1), 
            FechaFin = new DateTime(2026, 7, 31), 
            Activo = true,
            FechaCreacion = DateTime.UtcNow
        }
    };

    public async Task<IEnumerable<Presupuesto>> GetAllAsync()
    {
        await Task.Delay(10);
        return _presupuestos;
    }

    public async Task<Presupuesto?> GetByIdAsync(int id)
    {
        await Task.Delay(10);
        return _presupuestos.FirstOrDefault(p => p.IdPresupuesto == id);
    }
}
