using APIWarsUser.ActionClass.HelperClass.Drone;
using APIWarsUser.ActionClass.HelperClass.Enemy;
using System.Linq;
using System.Xml.Linq;

namespace APIWarsUser.ActionClass
{
    public class NetScanClass : INetScan
    {
        private readonly SpaceGameWorldContext _context;
        public NetScanClass(SpaceGameWorldContext context) => _context = context;

        public List<Information> GetEnemy(AccountData account)
        {
            try
            {
                if (_context.Accounts.Count(x => x.ApiKey == account.SecretKey && x.Login == account.Login) > 0)
                {
                    var dataDrone = _context.InformationDrones.FirstOrDefault(x => x.LoginUser == account.Login && x.DroneShortName == "DVR");
                    var propertyDrone = _context.EfficiencyActions.Where(x => x.Name == "Открыть область").ToList();

                    Vision view = new Vision(dataDrone.X, dataDrone.Y, propertyDrone.Select(x => x.ValueAction).FirstOrDefault());
                    long Xmin = view.XY1()[0];
                    long Xmax = view.XY2()[0];
                    long Ymin = view.XY2()[1];
                    long Ymax = view.XY1()[1];

                    var data = _context.InformationDrones.Select(
                        fi => new Information()
                        {
                            X = fi.X,
                            Y = fi.Y,
                            Ipv6 = fi.Ipv6,
                            DroneShortName = fi.DroneShortName,
                            HeatPoint = fi.HeatPoint,
                            LoginUser = fi.LoginUser,
                            Name = fi.DroneNameUser
                        }
                        ).Where(x => x.X >= Xmin && x.X <= Xmax &&
                                     x.Y >= Ymin && x.Y <= Ymax && x.LoginUser != account.Login).ToList();


                    return data;
                }
                return new List<Information>()
                {
                    new Information { X = 0, Y = 0 }
                };
            }
            catch
            {
                Results.BadRequest();
                throw;
            }
        }

        public List<NetScanDTO> GetInfoNow(AccountData account)
        {
            try
            {
                if (_context.Accounts.Count(x => x.ApiKey == account.SecretKey && x.Login == account.Login) > 0)
                {
                    var dataDrone = _context.InformationDrones.FirstOrDefault(x => x.LoginUser == account.Login && x.DroneShortName == "DVR");
                    var propertyDrone = _context.EfficiencyActions.Where(x => x.Name == "Открыть область").ToList();

                    Vision view = new Vision(dataDrone.X, dataDrone.Y, propertyDrone.Select(x => x.ValueAction).FirstOrDefault());
                    long Xmin = view.XY1()[0]; 
                    long Xmax = view.XY2()[0];
                    long Ymin = view.XY2()[1];
                    long Ymax = view.XY1()[1];

                    var data = _context.NetScans.Select(
                        fi => new NetScanDTO()
                        {
                            Name = fi.GameObject.Name,
                            X = fi.X,
                            Y = fi.Y,
                            HeatPoint = fi.GameObject.HeatPoint,
                            PlanetName = fi.PlanetName,
                        }
                        ).Where(x => x.X >= Xmin && x.X <= Xmax &&
                                     x.Y >= Ymin && x.Y <= Ymax).ToList();


                    return data;
                }
                return new List<NetScanDTO>()
                {
                    new NetScanDTO() { X = 0, Y = 0, PlanetName = "Такой планеты нету"}
                };
            }
            catch
            {
                Results.BadRequest();
                throw;
            }
        }
    }
}
