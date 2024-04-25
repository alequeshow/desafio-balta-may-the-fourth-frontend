using Starls.Assets.DTO;
using Starls.Assets.Service.Gateway.Interfaces;
using Starls.Assets.Service.Interfaces;

namespace Starls.Assets.Service
{
    public class SpecieService : ISpecieService
    {
        private readonly ISpecieGateway SpecieGateway;

        public SpecieService(ISpecieGateway SpecieGateway)
        {
            this.SpecieGateway = SpecieGateway;
        }

        public async Task<IEnumerable<Specie>> GetSpeciesAsync()
        {
            return await this.SpecieGateway.GetSpeciesAsync();
        }
    }
}