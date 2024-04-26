using Starls.Assets.DTO;
using Starls.Assets.DTO.Configuration;
using Starls.Assets.Service.Gateway.Extensions;
using Starls.Assets.Service.Gateway.Interfaces;

namespace Starls.Assets.Service.Gateway
{
    public class CharacterGateway : BaseGateway, ICharacterGateway
    {
        private readonly ProviderConfiguration CharacterProviderConfiguration;

        public CharacterGateway(IHttpClientFactory httpClientFactory, AppConfiguration appConfiguration) :
            base(httpClientFactory, appConfiguration.CharacterProviderConfiguration.Name)
        {
            this.CharacterProviderConfiguration = appConfiguration.CharacterProviderConfiguration;
        }

        public async Task<IEnumerable<Character>> GetCharacterAsync()
        {
            var urlPath = this.GetApiResourcePath(this.CharacterProviderConfiguration.Resource);

            if (this.CharacterProviderConfiguration.Paginated)
            {
                var pagedResult = await this.GetPagedAsync<SwApiResponseModel.Character>(urlPath);

                return pagedResult.ToDto().Results;
            }

            var result = await this.GetManyAsync<Character>(urlPath);

            return result ?? [];
        }
    }
}