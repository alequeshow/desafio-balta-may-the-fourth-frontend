using Starls.Assets.DTO;

namespace Starls.Assets.Service.Gateway.Extensions
{
    internal static class CharacterExtensions
    {
        internal static PagedContent<Character> ToDto(this PagedContent<SwApiResponseModel.Character> apiResponse)
        {
            if (apiResponse == null)
            {
                return new();
            }

            return new PagedContent<Character>
            {
                Count = apiResponse.Count,
                Next = apiResponse.Next,
                Previous = apiResponse.Previous,
                Results = apiResponse.Results.Select(r => r.ToDto()).ToList()
            };
        }

        internal static Character ToDto(this SwApiResponseModel.Character apiResponse)
        {
            if (apiResponse == null)
            {
                return new();
            }

            return new Character
            {
                Name = apiResponse.Name,
            };
        }
    }
}