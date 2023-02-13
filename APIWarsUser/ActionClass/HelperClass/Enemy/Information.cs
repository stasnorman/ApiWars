namespace APIWarsUser.ActionClass.HelperClass.Enemy
{
    public class Information
    {
        public long X { get; set; }
        public long Y { get; set; }
        public string Ipv6 { get; set; } = null!;
        public string DroneShortName { get; set; } = null!;
        public decimal? HeatPoint { get; set; }
        public string LoginUser { get; set; } = null!;
        public string? Name { get; set; }
    }
}
