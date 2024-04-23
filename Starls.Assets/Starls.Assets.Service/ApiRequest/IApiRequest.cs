namespace Starls.Assets.Service.ApiRequest
{
    public interface IApiRequest
    {
        Task<T> SendRequest<T>(string httpMethod);
    }
}
