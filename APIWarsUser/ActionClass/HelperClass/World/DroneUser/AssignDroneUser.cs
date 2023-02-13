using APIWarsUser.Models;

namespace APIWarsUser.ActionClass.HelperClass.World.DroneUser
{
    public class AssignDroneUser
    {
        private string loginUser { get; set; }
        private SpaceGameWorldContext spaceGameWorldContext { get; set; }
        public AssignDroneUser(SpaceGameWorldContext _data, string login)
        {
            loginUser = login;
            spaceGameWorldContext = _data;
            SetUserDrone();
        }

        private void SetUserDrone()
        {

            var getDrone = new SpaceGameWorldContext().Drones.ToArray();
            int Xtry = Oxy()[0];
            int Ytry = Oxy()[1];

            for (int i = 0; i < getDrone.Count(); i++)
            {
                InformationDrone informationDrone = new InformationDrone()
                {
                    X = Xtry,
                    Y = Ytry,
                    Ipv6 = new GenerationIpv6(1).GenerationIP().ToArray()[0],
                    DroneShortName = getDrone[i].ShortName,
                    LoginUser = loginUser,
                    DroneNameUser = "Edit",
                    HeatPoint = 300
                };

                spaceGameWorldContext.InformationDrones.Add(informationDrone);
                spaceGameWorldContext.SaveChanges();
            }

        kek:
            var ipv6 = new GenerationIpv6(1).GenerationIP();
            string code = new RandomString(4).GenerationWord().ToUpper();

            if (spaceGameWorldContext.GameObjects.Count(x => x.Ipv6 == ipv6[0]) > 0)
                goto kek;
            else
            {
                var gameObject = new GameObject()
                {
                    Name = loginUser + "-Home",
                    TypeObject = "Базовая станция",
                    Ipv6 = ipv6.ToArray().First(),
                    StateObject = "Нейтрален",
                    HeatPoint = 1000
                };

                spaceGameWorldContext.GameObjects.Add(gameObject);
                spaceGameWorldContext.SaveChanges();

                NetScan netScan = new NetScan()
                {
                    X = Xtry,
                    Y = Ytry,
                    GameObjectId = gameObject.Id,
                    EventNewCodeNumber = "E200",
                    PlanetName = "Земля"
                };
                spaceGameWorldContext.NetScans.Add(netScan);
                spaceGameWorldContext.SaveChanges();

                ObjectAvailable objectAvailable = new ObjectAvailable()
                {
                    ServerId = gameObject.Id,
                    LoginUser = loginUser,
                    ServerLevel = 0,
                };
                spaceGameWorldContext.ObjectAvailables.Add(objectAvailable);
                spaceGameWorldContext.SaveChanges();


            }
        }

        private int[] Oxy()
        {
            var coordinate = new SpaceGameWorldContext().Planets.FirstOrDefault(x => x.Name == "Земля");

            Random random = new Random();

            return new int[] {
                random.Next(coordinate.Longitude * -1, coordinate.Longitude),
                random.Next(coordinate.Latitude * -1, coordinate.Latitude)
            };
        }
    }
}
