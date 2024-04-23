
using Newtonsoft.Json;

namespace Starls.Assets.Service.ApiRequest
{
    public class ApiRequest : IApiRequest
    {
        public async Task<T> SendRequest<T>(string httpMethod)
        {
            try
            {
                HttpClient client = new HttpClient();

                HttpRequestMessage request = RequestConstructor(httpMethod);

                HttpResponseMessage response = await client.SendAsync(request);
                string responseReaded = await response.Content.ReadAsStringAsync();

                var objectDeserialized = JsonConvert.DeserializeObject<T>(responseReaded);

                return objectDeserialized;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private HttpRequestMessage RequestConstructor(string type)
        {
            HttpRequestMessage request = new HttpRequestMessage();

            request.RequestUri = new Uri("https://swapi.py4e.com/api/");
            request.Method = type switch
            {
                "POST" => HttpMethod.Post,
                "PUT" => HttpMethod.Put,
                "PATCH" => HttpMethod.Patch,
                "DELETE" => HttpMethod.Delete,
                _ => HttpMethod.Get
            };

            return request;
        }
    }
}
