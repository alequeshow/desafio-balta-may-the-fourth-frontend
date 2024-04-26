namespace Starls.Assets.DTO.Configuration
{
    public class AppConfiguration
    {
        public ProviderConfiguration FilmProviderConfiguration { get; set; } 

        public ProviderConfiguration VehicleProviderConfiguration { get; set; }
      
        public ProviderConfiguration PlanetProviderConfiguration { get; set; }

        public ProviderConfiguration StarshipProviderConfiguration { get; set; }
      
        public ProviderConfiguration CharacterProviderConfiguration { get; set; }

    }
}