using Starls.Assets.DTO;

namespace Starls.Assets.Service.Gateway.Interfaces;

public interface IFilmGateway
{
    Task<IEnumerable<Film>> GetFilmsAsync();
}