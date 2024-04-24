using Starls.Assets.DTO;
using Starls.Assets.DTO.Configuration;
using Starls.Assets.Service.Gateway.Extensions;
using Starls.Assets.Service.Gateway.Interfaces;

namespace Starls.Assets.Service.Gateway
{
    public class VehicleGateway : BaseGateway, IVehicleGateway
    {
        private readonly ProviderConfiguration VehicleProviderConfiguration;
        public VehicleGateway(IHttpClientFactory httpClientFactory, AppConfiguration appConfiguration) :
            base(httpClientFactory, appConfiguration.VehicleProviderConfiguration.Name)
        {
            this.VehicleProviderConfiguration = appConfiguration.VehicleProviderConfiguration;
        }

        public async Task<IEnumerable<Vehicle>> GetVehiclesAsync()
        {
            string urlPath = this.GetApiResourcePath(this.VehicleProviderConfiguration.Resource);

            if (this.VehicleProviderConfiguration.Paginated)
            {
                var pagedResult = await this.GetPagedAsync<SwApiResponseModel.Vehicle>(urlPath);

                return pagedResult.ToDto().Results;
            }

            var result = await this.GetManyAsync<Vehicle>(urlPath);

            return result ?? [];
        }
    }
}
