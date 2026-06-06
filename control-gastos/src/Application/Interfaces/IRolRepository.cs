using Domain.Entities;

namespace Application.Interfaces;

public interface IRolRepository
{
    Task<IEnumerable<Rol>> GetAllAsync();
    Task<Rol?> GetByIdAsync(int id);
}
