using Starls.Assets.DTO;

namespace Starls.Assets.Service.Interfaces
{
    public interface IVehicleService
    {
        Task<IEnumerable<Vehicle>> GetVehiclesAsync();
    }
}
