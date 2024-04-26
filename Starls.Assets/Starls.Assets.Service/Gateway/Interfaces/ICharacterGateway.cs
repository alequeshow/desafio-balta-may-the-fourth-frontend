using Starls.Assets.DTO;

namespace Starls.Assets.Service.Gateway.Interfaces;

public interface ICharacterGateway
{
    Task<IEnumerable<Character>> GetCharacterAsync(); 
}