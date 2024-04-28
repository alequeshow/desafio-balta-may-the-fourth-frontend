using Starls.Assets.DTO;
using Starls.Assets.DTO.Configuration;
using Starls.Assets.Service.Gateway.Extensions;
using Starls.Assets.Service.Gateway.Interfaces;

namespace Starls.Assets.Service.Gateway
{
    public class FilmGateway : BaseGateway, IFilmGateway
    {
        private readonly ProviderConfiguration FilmProviderConfiguration;

        public FilmGateway(IHttpClientFactory httpClientFactory, AppConfiguration appConfiguration) :
            base(httpClientFactory, appConfiguration.FilmProviderConfiguration.Name)
        {
            this.FilmProviderConfiguration = appConfiguration.FilmProviderConfiguration;
        }

        public async Task<IEnumerable<Film>> GetFilmsAsync()
        {
            var urlPath = this.GetApiResourcePath(this.FilmProviderConfiguration.Resource);

            if (this.FilmProviderConfiguration.UseSwApiContract)
            {
                if (this.FilmProviderConfiguration.Paginated)
                {
                    var swApiPagedResult = await this.GetPagedAsync<SwApiResponseModel.Film>(urlPath);

                    return swApiPagedResult.ToDto().Results;
                }
                else
                {
                    throw new Exception($"SwAPI only implements paginated response, review the {nameof(this.FilmProviderConfiguration)} pagination settings");
                }
            }

            if (this.FilmProviderConfiguration.Paginated)
            {
                var pagedResult = await this.GetPagedAsync<Film>(urlPath);

                return pagedResult.Results ?? [];
            }

            var result = await this.GetManyAsync<Film>(urlPath);

            return result ?? [];
        }
    }
}