using Domain.Entities;

namespace Application.Interfaces;

public interface IPresupuestoRepository
{
    Task<IEnumerable<Presupuesto>> GetAllAsync();
    Task<Presupuesto?> GetByIdAsync(int id);
}
