namespace Starls.Assets.Service.Gateway.SwApiResponseModel
{
    public class Planet
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal RotationPeriod { get; set; }

        public int OrbitalPeriod { get; set; }

        public decimal Diameter { get; set; }

        public string Climate { get; set; } = string.Empty;

        public decimal Gravity { get; set; }

        public string Terrain { get; set; } = string.Empty;

        public decimal SurfaceWater { get; set; }

        public decimal Population { get; set; }

        public List<string> Characteres { get; set; } = new();

        public List<string> Movies { get; set; } = new();
    }
}
