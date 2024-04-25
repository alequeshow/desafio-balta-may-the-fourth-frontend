using Starls.Assets.DTO;

namespace Starls.Assets.Service.Gateway.Extensions
{
    internal static class PlanetExtensions
    {
        internal static PagedContent<Planet> ToDto(this PagedContent<SwApiResponseModel.Planet> apiResponse)
        {
            if(apiResponse is null)
            {
                return new();
            }

            return new PagedContent<Planet>
            {
                Count = apiResponse.Count,
                Next = apiResponse.Next,
                Previous = apiResponse.Previous,
                Results = apiResponse.Results.Select(r => r.ToDto()).ToList()
            };
        }

        internal static Planet ToDto(this SwApiResponseModel.Planet apiResponse)
        {
            if(apiResponse is null)
            {
                return new();
            }

            return new Planet
            {
                Name = apiResponse.Name,
            };
        }
    }
}
