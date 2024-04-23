using Starls.Assets.DTO;
using System.Net.Http.Json;

namespace Starls.Assets.Service.Gateway
{
    public class BaseGateway
    {
        private HttpClient httpClient;

        internal BaseGateway(IHttpClientFactory httpClientFactory, string clientName)
        {
            this.httpClient = httpClientFactory.CreateClient(clientName);
        }

        internal async Task<PagedContent<T>> GetPagedAsync<T>(string path)
        {
            try
            {
                var result = await this.httpClient.GetFromJsonAsync<PagedContent<T>>(path);

                return result;
            }
            catch (Exception)
            {
                //Log possible errors

                throw;
            }
        }

        internal async Task<IEnumerable<T>> GetManyAsync<T>(string path)
        {
            try
            {
                var result = await this.httpClient.GetFromJsonAsync<IEnumerable<T>>(path);

                return result;
            }
            catch (Exception)
            {
                //Log possible errors

                throw;
            }
        }

        protected string GetApiResourcePath(string apiResourcePath, int page = 0)
        {
            if (page > 0)
            {
                return $"{apiResourcePath}/?page={page}";
            }

            return apiResourcePath;
        }
    }
}