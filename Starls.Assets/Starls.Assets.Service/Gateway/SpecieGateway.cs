using Starls.Assets.DTO;
using Starls.Assets.DTO.Configuration;
using Starls.Assets.Service.Gateway.Extensions;
using Starls.Assets.Service.Gateway.Interfaces;

namespace Starls.Assets.Service.Gateway
{
    public class SpecieGateway : BaseGateway, ISpecieGateway
    {
        private readonly ProviderConfiguration SpecieProviderConfiguration;

        public SpecieGateway(IHttpClientFactory httpClientFactory, AppConfiguration appConfiguration) :
            base(httpClientFactory, appConfiguration.SpecieProviderConfiguration.Name)
        {
            this.SpecieProviderConfiguration = appConfiguration.SpecieProviderConfiguration;
        }

        public async Task<IEnumerable<Specie>> GetSpeciesAsync()
        {
            var urlPath = this.GetApiResourcePath(this.SpecieProviderConfiguration.Resource);

            if (this.SpecieProviderConfiguration.Paginated)
            {
                var pagedResult = await this.GetPagedAsync<SwApiResponseModel.Specie>(urlPath);

                return pagedResult.ToDto().Results;
            }

            var result = await this.GetManyAsync<Specie>(urlPath);

            return result ?? [];
        }
    }
}