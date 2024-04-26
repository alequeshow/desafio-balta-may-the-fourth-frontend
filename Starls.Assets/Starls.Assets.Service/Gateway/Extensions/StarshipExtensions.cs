using Starls.Assets.DTO;

namespace Starls.Assets.Service.Gateway.Extensions
{
    internal static class StarshipExtensions
    {
        internal static PagedContent<Starship> ToDto(this PagedContent<SwApiResponseModel.Starship> apiResponse)
        {
            if (apiResponse == null)
            {
                return new();
            }

            return new PagedContent<Starship>
            {
                Count = apiResponse.Count,
                Next = apiResponse.Next,
                Previous = apiResponse.Previous,
                Results = apiResponse.Results.Select(r => r.ToDto()).ToList()
            };
        }

        internal static Starship ToDto(this SwApiResponseModel.Starship apiResponse)
        {
            if (apiResponse == null)
            {
                return new();
            }

            return new Starship
            {
                Name = apiResponse.Name,
            };
        }
    }
}