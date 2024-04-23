namespace Starls.Assets.DTO;

public class Vehicle
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public string ManuFacturer { get; set; } = string.Empty;

    public decimal CostInCredits { get; set; } 

    public decimal Length { get; set; } 

    public decimal MaxSpeed { get; set; } 

    public int Crew { get; set; }

    public int Passengers { get; set; }

    public int CargoCapacity { get; set; }

    public int Consumables { get; set; }

    public string Class { get; set; } = string.Empty;

    public List<Film> Movies { get; set; } = new();

}