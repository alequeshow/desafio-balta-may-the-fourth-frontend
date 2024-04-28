namespace Starls.Assets.Service.Gateway.SwApiResponseModel
{
    public class Planet
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string RotationPeriod { get; set; } = string.Empty;

        public int OrbitalPeriod { get; set; }

        public string Diameter { get; set; } = string.Empty;

        public string Climate { get; set; } = string.Empty;

        public string Gravity { get; set; } = string.Empty;

        public string Terrain { get; set; } = string.Empty;

        public string SurfaceWater { get; set; } = string.Empty;

        public string Population { get; set; } = string.Empty;

        public List<Starship> Characteres { get; set; } = new();

        public List<Film> Movies { get; set; } = new();
    }
}
