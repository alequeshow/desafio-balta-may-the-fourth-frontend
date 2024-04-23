namespace Starls.Assets.DTO;

public class Specie
{
    public string Name { get; set; } = string.Empty;

    public string Classification { get; set; } = string.Empty;

    public string Designation { get; set; } = string.Empty;

    public int AverageHeight { get; set; }

    public List<string> SkinColors { get; set; } = new();

    public List<string> HairColors { get; set; } = new();

    public List<string> EyeColors { get; set; } = new(); 

    public int AverageLifespan { get; set; }

    public string Homeworld { get; set; } = string.Empty;

    public string Language { get; set; } = string.Empty;

    public List<Film> Films { get; set; } = new ();

    public DateTime Created { get; set; }

    public DateTime Edited { get; set; }

    public string Url { get; set; } = string.Empty;

}