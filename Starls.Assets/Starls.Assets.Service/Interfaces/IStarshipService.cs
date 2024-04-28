using Starls.Assets.DTO;

namespace Starls.Assets.Service.Interfaces
{
    public interface IStarshipService
    {
        Task<IEnumerable<Starship>> GetStarshipsAsync();
    
    }
}