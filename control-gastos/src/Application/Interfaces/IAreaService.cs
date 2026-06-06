using Application.DTOs;

namespace Application.Interfaces;

public interface IAreaService
{
    Task<IEnumerable<AreaDto>> GetAllAsync();
    Task<AreaDto?> GetByIdAsync(int id);
}