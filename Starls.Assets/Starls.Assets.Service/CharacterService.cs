using Starls.Assets.DTO;
using Starls.Assets.Service.Gateway.Interfaces;
using Starls.Assets.Service.Interfaces;

namespace Starls.Assets.Service
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterGateway _characterGateway;

        public CharacterService(ICharacterGateway characterGateway)
        {
            _characterGateway = characterGateway;
        }

        public async Task<IEnumerable<Character>> GetCharacterAsync()
        {
            return  await this._characterGateway.GetCharacterAsync();
        }

    
    }
}
