using Application.DTOs;

namespace Application.Interfaces;

public interface IPresupuestoService
{
    Task<IEnumerable<PresupuestoDto>> GetAllAsync();
    Task<PresupuestoDto?> GetByIdAsync(int id);
}
