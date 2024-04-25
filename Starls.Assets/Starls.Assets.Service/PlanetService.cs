using Starls.Assets.DTO;
using Starls.Assets.Service.Gateway.Interfaces;
using Starls.Assets.Service.Interfaces;

namespace Starls.Assets.Service
{
    public class PlanetService : IPlanetService
    {
        private readonly IPlanetGateway _planetGateway;

        public PlanetService(IPlanetGateway planetGateway)
        {
            _planetGateway = planetGateway;
        }
        public async Task<IEnumerable<Planet>> GetPlanetsAsync()
        {
            return await _planetGateway.GetPlanetsAsync();
        }
    }
}
