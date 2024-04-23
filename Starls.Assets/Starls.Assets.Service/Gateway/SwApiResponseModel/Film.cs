namespace Starls.Assets.Service.Gateway.SwApiResponseModel;

public class Film
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public int Episode { get; set; }

    public string OpeningCrawl { get; set; } = string.Empty;

    public string Director { get; set; } = string.Empty;

    public string Producer { get; set; } = string.Empty;

    public DateTime ReleaseDAte { get; set; }

    public List<string> Characteres { get; set; } = new();

    public List<string> Planets { get; set; } = new();

    public List<string> Vehicles { get; set; } = new();

    public List<string> Starships { get; set; } = new();
}