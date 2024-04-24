using Starls.Assets.DTO;
using Starls.Assets.DTO.Configuration;
using Starls.Assets.Service.Gateway.Extensions;
using Starls.Assets.Service.Gateway.Interfaces;

namespace Starls.Assets.Service.Gateway
{
    public class CharacterGateway : BaseGateway, ICharacterGateway
    {
        private readonly ProviderConfiguration FilmProviderConfiguration;

        public CharacterGateway(IHttpClientFactory httpClientFactory, AppConfiguration appConfiguration) :
            base(httpClientFactory, appConfiguration.FilmProviderConfiguration.Name)
        {
            this.FilmProviderConfiguration = appConfiguration.FilmProviderConfiguration;
        }

        public async Task<IEnumerable<Character>> ICharacterGateway()
        {
            var urlPath = this.GetApiResourcePath(this.FilmProviderConfiguration.Resource);

            if (this.FilmProviderConfiguration.Paginated)
            {
                var pagedResult = await this.GetPagedAsync<SwApiResponseModel.Character>(urlPath);

                return pagedResult.ToDto().Results;
            }

            var result = await this.GetManyAsync<Character>(urlPath);

            return result ?? [];
        }
    }
}