using Starls.Assets.DTO;
using Starls.Assets.Service.Gateway.Interfaces;
using Starls.Assets.Service.Interfaces;

namespace Starls.Assets.Service
{
    public class StarshipService : IStarshipService
    {
        private readonly IStarshipGateway StarshipGateway;

        public StarshipService(IStarshipGateway StarshipGateway)
        {
            this.StarshipGateway = StarshipGateway;
        }

        public async Task<IEnumerable<Starship>> GetStarshipsAsync() 
        {
            return await this.StarshipGateway.GetStarshipsAsync();
        }
    }
}