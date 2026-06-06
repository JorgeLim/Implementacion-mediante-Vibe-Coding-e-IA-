using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services;

public class PresupuestoService : IPresupuestoService
{
    private readonly IPresupuestoRepository _repository;

    public PresupuestoService(IPresupuestoRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<PresupuestoDto>> GetAllAsync()
    {
        var presupuestos = await _repository.GetAllAsync();
        return presupuestos.Select(p => new PresupuestoDto
        {
            IdPresupuesto = p.IdPresupuesto,
            IdArea = p.IdArea,
            IdCentroCosto = p.IdCentroCosto,
            Periodo = p.Periodo,
            MontoTotal = p.MontoTotal,
            MontoUtilizado = p.MontoUtilizado,
            FechaInicio = p.FechaInicio,
            FechaFin = p.FechaFin,
            Activo = p.Activo,
            FechaCreacion = p.FechaCreacion,
            FechaActualizacion = p.FechaActualizacion
        });
    }

    public async Task<PresupuestoDto?> GetByIdAsync(int id)
    {
        var presupuesto = await _repository.GetByIdAsync(id);
        if (presupuesto == null) return null;

        return new PresupuestoDto
        {
            IdPresupuesto = presupuesto.IdPresupuesto,
            IdArea = presupuesto.IdArea,
            IdCentroCosto = presupuesto.IdCentroCosto,
            Periodo = presupuesto.Periodo,
            MontoTotal = presupuesto.MontoTotal,
            MontoUtilizado = presupuesto.MontoUtilizado,
            FechaInicio = presupuesto.FechaInicio,
            FechaFin = presupuesto.FechaFin,
            Activo = presupuesto.Activo,
            FechaCreacion = presupuesto.FechaCreacion,
            FechaActualizacion = presupuesto.FechaActualizacion
        };
    }
}
