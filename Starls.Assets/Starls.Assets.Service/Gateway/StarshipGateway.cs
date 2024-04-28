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

            if (this.StarshipProviderConfiguration.UseSwApiContract)
            {
                if (this.StarshipProviderConfiguration.Paginated)
                {
                    var swApiPagedResult = await this.GetPagedAsync<SwApiResponseModel.Starship>(urlPath);

                    return swApiPagedResult.ToDto().Results;
                }
                else
                {
                    throw new Exception($"SwAPI only implements paginated response, review the {nameof(this.StarshipProviderConfiguration)} pagination settings");
                }
            }

            if (this.StarshipProviderConfiguration.Paginated)
            {
                var pagedResult = await this.GetPagedAsync<Starship>(urlPath);

                return pagedResult.Results ?? [];
            }

            var result = await this.GetManyAsync<Starship>(urlPath);

            return result ?? [];
        }
    }
}