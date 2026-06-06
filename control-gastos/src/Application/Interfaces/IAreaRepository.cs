using Domain.Entities;

namespace Application.Interfaces;

public interface IAreaRepository
{
    Task<IEnumerable<Area>> GetAllAsync();
    Task<Area?> GetByIdAsync(int id);
}
