using Application.DTOs;

namespace Application.Interfaces;

public interface IRolService
{
    Task<IEnumerable<RolDto>> GetAllAsync();
    Task<RolDto?> GetByIdAsync(int id);
}