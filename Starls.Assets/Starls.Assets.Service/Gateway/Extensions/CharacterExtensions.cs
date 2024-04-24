using Starls.Assets.DTO;

namespace Starls.Assets.Service.Gateway.Extensions
{
    internal static class FilmExtensions
    {
        internal static PagedContent<Film> ToDto(this PagedContent<SwApiResponseModel.Film> apiResponse)
        {
            if (apiResponse == null)
            {
                return new();
            }

            return new PagedContent<Film>
            {
                Count = apiResponse.Count,
                Next = apiResponse.Next,
                Previous = apiResponse.Previous,
                Results = apiResponse.Results.Select(r => r.ToDto()).ToList()
            };
        }

        internal static Film ToDto(this SwApiResponseModel.Film apiResponse)
        {
            if (apiResponse == null)
            {
                return new();
            }

            return new Film
            {
                Title = apiResponse.Title,
            };
        }
    }
}