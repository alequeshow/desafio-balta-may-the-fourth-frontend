using Starls.Assets.DTO;

namespace Starls.Assets.Service.Gateway.Interfaces;

public interface ISpecieGateway
{
    Task<IEnumerable<Specie>> GetSpeciesAsync();
}