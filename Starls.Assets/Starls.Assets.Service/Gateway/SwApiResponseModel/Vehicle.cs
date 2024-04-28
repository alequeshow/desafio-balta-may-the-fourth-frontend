namespace Starls.Assets.Service.Gateway.SwApiResponseModel
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public string ManuFacturer { get; set; } = string.Empty;

        public string CostInCredits { get; set; } = string.Empty;

        public string Length { get; set; } = string.Empty;

        public string MaxSpeed { get; set; } = string.Empty;

        public string Crew { get; set; } = string.Empty;

        public string Passengers { get; set; } = string.Empty;

        public string CargoCapacity { get; set; } = string.Empty;

        public string Consumables { get; set; } = string.Empty;

        public string Class { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public List<Film> Movies { get; set; } = new();
    }
}
