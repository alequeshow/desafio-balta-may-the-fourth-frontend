using Starls.Assets.DTO;

namespace Starls.Assets.Service.Gateway.SwApiResponseModel;

public class Character
    {
    public string Name { get; set; } = string.Empty;

    public string Height { get; set; }

    public string Mass { get; set; }

    public string Hair_Color { get; set; } = string.Empty;

    public string Skin_Color { get; set; } = string.Empty;

    public string Eye_Color { get; set; } = string.Empty;

    public string Birth_Year { get; set; } = string.Empty;

    public string Gender { get; set; } = string.Empty;

    public string Homeworld { get; set; } = string.Empty;

    public List<string> Films { get; set; } = new();

    public List<string> Vehicles { get; set; } = new();

    //public List<Starship> Starships { get; set; } = new();

}
