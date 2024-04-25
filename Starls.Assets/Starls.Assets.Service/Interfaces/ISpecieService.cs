using Starls.Assets.DTO;

namespace Starls.Assets.Service.Interfaces
{
    public interface ISpecieService
    {
        Task<IEnumerable<Specie>> GetSpeciesAsync();
    }
}