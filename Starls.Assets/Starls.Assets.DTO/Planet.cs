namespace Starls.Assets.DTO;

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

    public List<Character> Characteres { get; set; } = new();

    public List<Film> Movies { get; set; } = new();
}