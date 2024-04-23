namespace Starls.Assets.DTO.Configuration
{
    public class ProviderConfiguration
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string Resource { get; set; }

        public bool Paginated { get; set; }

        public bool UseRecursiveReference { get; set; }
    }
}