using APIWarsUser.Models;

namespace APIWarsUser.ActionClass.HelperClass.World.DroneUser
{
    public class AssignGameObjectXY
    {

        private SpaceGameWorldContext spaceGameWorldContext { get; set; }
        private long Id { get; set; }
        public AssignGameObjectXY(SpaceGameWorldContext _contextGet, long IdGameObject)
        {
            spaceGameWorldContext = _contextGet;
            Id = IdGameObject;

            Generation();
        }

        private void Generation()
        {
            long Xtry = Oxy()[0];
            long Ytry = Oxy()[1];

            NetScan netScan = new NetScan() {
                X = Xtry,
                Y = Ytry,
                GameObjectId = Id,
                EventNewCodeNumber = "W200",
                PlanetName = "Земля"
            };
            spaceGameWorldContext.NetScans.Add(netScan);
            spaceGameWorldContext.SaveChanges();
        }

        private long[] Oxy()
        {
            var coordinate = new SpaceGameWorldContext().Planets.FirstOrDefault(x => x.Name == "Земля");

            Random random = new Random();

            return new long[] {
                random.Next(coordinate.Longitude * -1, coordinate.Longitude),
                random.Next(coordinate.Latitude * -1, coordinate.Latitude)
            };
        }
    }
}
