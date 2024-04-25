using Starls.Assets.DTO;

namespace Starls.Assets.Service.Gateway.Extensions
{
    internal static class SpecieExtensions
    {
        internal static PagedContent<Specie> ToDto(this PagedContent<SwApiResponseModel.Specie> apiResponse)
        {
            if (apiResponse == null)
            {
                return new();
            }

            return new PagedContent<Specie>
            {
                Count = apiResponse.Count,
                Next = apiResponse.Next,
                Previous = apiResponse.Previous,
                Results = apiResponse.Results.Select(r => r.ToDto()).ToList()
            };
        }

        internal static Specie ToDto(this SwApiResponseModel.Specie apiResponse)
        {
            if (apiResponse == null)
            {
                return new();
            }

            return new Specie
            {
                Name = apiResponse.Name,
            };
        }
    }
}