using Starls.Assets.DTO;

namespace Starls.Assets.Service.Gateway.Extensions
{
    internal static class VehicleExtensions
    {
        internal static PagedContent<Vehicle> ToDto(this PagedContent<SwApiResponseModel.Vehicle> apiResponse)
        {
            if (apiResponse is null)
            {
                return new();
            }

            return new PagedContent<Vehicle>
            {
                Count = apiResponse.Count,
                Next = apiResponse.Next,
                Previous = apiResponse.Previous,
                Results = apiResponse.Results.Select(r => r.ToDto()).ToList()
            };

        }

        internal static Vehicle ToDto(this SwApiResponseModel.Vehicle apiResponse)
        {
            if (apiResponse is null)
            {
                return new();
            }

            return new Vehicle
            {
                Name = apiResponse.Name,
            };
        }
    }
}
