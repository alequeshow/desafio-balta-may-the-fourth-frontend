using Starls.Assets.DTO;
using Starls.Assets.DTO.Configuration;
using Starls.Assets.Service.Gateway.Extensions;
using Starls.Assets.Service.Gateway.Interfaces;

namespace Starls.Assets.Service.Gateway
{
    public class PlanetGateway : BaseGateway, IPlanetGateway
    {
        private readonly ProviderConfiguration PlanetProviderConfiguration;
        public PlanetGateway(IHttpClientFactory httpClientFactory, AppConfiguration appConfiguration) : 
            base(httpClientFactory, appConfiguration.PlanetProviderConfiguration.Name)
        {
            this.PlanetProviderConfiguration = appConfiguration.PlanetProviderConfiguration;
        }

        public async Task<IEnumerable<Planet>> GetPlanetsAsync()
        {
            string urlPath = this.GetApiResourcePath(this.PlanetProviderConfiguration.Resource);

            if (this.PlanetProviderConfiguration.Paginated)
            {
                var pagedResult = await this.GetPagedAsync<SwApiResponseModel.Planet>(urlPath);

                return pagedResult.ToDto().Results;
            }

            var result = await this.GetManyAsync<Planet>(urlPath);

            return result ?? [];
        }
    }
}
