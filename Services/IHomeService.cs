using HomeAssets.DTOs;

namespace HomeAssets.Services;

public interface IHomeService
{
    Task<HomeDTO> GetHomeDataAsync();
}