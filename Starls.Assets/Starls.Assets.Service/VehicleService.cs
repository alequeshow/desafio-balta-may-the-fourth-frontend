using Starls.Assets.DTO;
using Starls.Assets.Service.Gateway.Interfaces;
using Starls.Assets.Service.Interfaces;

namespace Starls.Assets.Service
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleGateway _vehicleGateway;
        public VehicleService(IVehicleGateway vehicleGateway)
        {
            _vehicleGateway = vehicleGateway;
        }
        public async Task<IEnumerable<Vehicle>> GetVehiclesAsync()
        {
            return await _vehicleGateway.GetVehiclesAsync();
        }
    }
}
