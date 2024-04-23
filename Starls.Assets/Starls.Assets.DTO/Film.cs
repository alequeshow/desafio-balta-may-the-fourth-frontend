namespace Starls.Assets.DTO;

public class Film
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public int Episode { get; set; }

    public string OpeningCrawl { get; set; } = string.Empty;

    public string Director { get; set; } = string.Empty;

    public string Producer { get; set; } = string.Empty;

    public DateTime ReleaseDAte { get; set; }

    public List<Character> Characteres { get; set; } = new();

    public List<Planet> Planets { get; set; } = new();

    public List<Vehicle> Vehicles { get; set; } = new();

    public List<Starship> Starships { get; set; } = new();


}