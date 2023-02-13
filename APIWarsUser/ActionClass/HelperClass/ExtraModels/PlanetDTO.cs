namespace APIWarsUser.ActionClass.HelperClass.ExtraModels
{
    public class PlanetDTO
    {
        public string Name { get; set; } = null!; 
        public string Description { get; set; } = null!;
        public string Square { get; set; } = null!;
        public int Latitude { get; set; }
        public int Longitude { get; set; }
    }
}
