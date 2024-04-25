using Starls.Assets.DTO;

namespace Starls.Assets.Service.Gateway.Interfaces
{
    public interface IStarshipGateway
    {
        Task<IEnumerable<Starship>> GetStarshipsAsync();
    }
}
