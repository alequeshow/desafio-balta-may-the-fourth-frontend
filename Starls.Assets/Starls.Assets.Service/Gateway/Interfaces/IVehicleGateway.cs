using Starls.Assets.DTO;

namespace Starls.Assets.Service.Gateway.Interfaces
{
    public interface IVehicleGateway
    {
        Task<IEnumerable<Vehicle>> GetVehiclesAsync();
    }
}
