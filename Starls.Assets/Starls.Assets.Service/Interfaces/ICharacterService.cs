using Starls.Assets.DTO;

namespace Starls.Assets.Service.Interfaces
{
    public interface ICharacterService
    {
        Task<IEnumerable<Character>> GetCharacterAsync();
    }
}