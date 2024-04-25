using Starls.Assets.DTO;

namespace Starls.Assets.Service.Interfaces
{
    public interface IPlanetService
    {
        Task<IEnumerable<Planet>> GetPlanetsAsync();
    }
}
