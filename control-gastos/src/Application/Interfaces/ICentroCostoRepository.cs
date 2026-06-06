using Domain.Entities;

namespace Application.Interfaces;

public interface ICentroCostoRepository
{
    Task<IEnumerable<CentroCosto>> GetAllAsync();
    Task<CentroCosto?> GetByIdAsync(int id);
}
