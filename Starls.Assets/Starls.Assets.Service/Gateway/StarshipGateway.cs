using Starls.Assets.DTO;
using Starls.Assets.DTO.Configuration;
using Starls.Assets.Service.Gateway.Extensions;
using Starls.Assets.Service.Gateway.Interfaces;

namespace Starls.Assets.Service.Gateway
{
    public class StarshipGateway : BaseGateway, IStarshipGateway
    {
        private readonly ProviderConfiguration StarshipProviderConfiguration;

        public StarshipGateway(IHttpClientFactory httpClientFactory, AppConfiguration appConfiguration) :
            base(httpClientFactory, appConfiguration.StarshipProviderConfiguration.Name)
        {
            this.StarshipProviderConfiguration = appConfiguration.StarshipProviderConfiguration;
        }

        public async Task<IEnumerable<Starship>> GetStarshipsAsync()
        {
            var urlPath = this.GetApiResourcePath(this.StarshipProviderConfiguration.Resource);

            if (this.StarshipProviderConfiguration.Paginated)
            {
                var pagedResult = await this.GetPagedAsync<SwApiResponseModel.Starship>(urlPath);

                return pagedResult.ToDto().Results;
            }

            var result = await this.GetManyAsync<Starship>(urlPath);

            return result ?? [];
        }
    }
}