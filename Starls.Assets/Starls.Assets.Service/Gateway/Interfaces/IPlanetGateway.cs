using Starls.Assets.DTO;

namespace Starls.Assets.Service.Gateway.Interfaces
{
    public interface IPlanetGateway
    {
        Task<IEnumerable<Planet>> GetPlanetsAsync();
    }
}
