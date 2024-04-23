namespace Starls.Assets.DTO;

public class Pilot
{
    public string Name { get; set; } = string.Empty;

    public decimal Height { get; set; }

    public decimal Mass { get; set; }

    public string Hair_color { get; set; } = string.Empty;

    public string Skin_color { get; set; } = string.Empty;

    public string Eye_color { get; set; } = string.Empty;

    public string Birth_year { get; set; } = string.Empty;

    public string Gender { get; set; } = string.Empty;

    public string Homeworld { get; set; } = string.Empty;

    public List<Film> Movies { get; set; } = new();

    public List<Specie> Species { get; set; } = new();

    public List<Vehicle> Vehicles { get; set; } = new();

    public List<Starship> Starships { get; set; } = new();

    public DateTime Created { get; set; }

    public DateTime Edited { get; set; }

    public string Url { get; set; } = string.Empty;
}