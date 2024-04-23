using Starls.Assets.DTO;

namespace Starls.Assets.Service.Interfaces
{
    public interface IFilmService
    {
        Task<IEnumerable<Film>> GetFilmsAsync();
    }
}