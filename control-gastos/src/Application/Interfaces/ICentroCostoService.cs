using Application.DTOs;

namespace Application.Interfaces;

public interface ICentroCostoService
{
    Task<IEnumerable<CentroCostoDto>> GetAllAsync();
    Task<CentroCostoDto?> GetByIdAsync(int id);
}