using APIWarsUser.Models;
using Microsoft.EntityFrameworkCore;

namespace APIWarsUser.ActionClass.HelperClass.Drone
{
    public class Move : IMove
    {
        private readonly SpaceGameWorldContext connect;
        private ObjectMove _objectMove;
        private IEnumerable<InformationDrone> dataDrone { get; set; }


        public Move(SpaceGameWorldContext _context)
        {
            connect = _context;
        }

        public List<InformationDrone> MoveDrone(ObjectMove drone)
        {
            _objectMove = drone;
            try
            {
                //Проверка валидации пользователя
                if (connect.Accounts.Count(x => x.ApiKey == drone.SecretKey && x.Login == drone.Login) > 0)
                {

                    //Получаю список дронов пользователя
                    dataDrone = connect.InformationDrones.Where(
                            x => x.LoginUser == drone.Login
                        );


                    //Получаю данные в виде количества перемещения клеток для дрона
                    var propertyDrone = connect.Drones.Where(x => x.ShortName == drone.ShortNameDrone).ToList();


                    var movedata = propertyDrone.Select(x => x.MoveAction);
                    switch (drone.Angle)
                    {
                        case 0: MoveUp(movedata.Single(), drone.Ipv6, drone.ShortNameDrone); break;
                        case 360: MoveUp(movedata.Single(), drone.Ipv6, drone.ShortNameDrone); break;
                        case 45: MoveUp45(movedata.Single(), drone.Ipv6, drone.ShortNameDrone, drone.Angle); break;
                        case 90: MoveRight(movedata.Single(), drone.Ipv6, drone.ShortNameDrone); break;
                        case 135: MoveDown135(movedata.Single(), drone.Ipv6, drone.ShortNameDrone, drone.Angle); break;
                        case 180: MoveDown(movedata.Single(), drone.Ipv6, drone.ShortNameDrone); break;
                        case 225: MoveDown225(movedata.Single(), drone.Ipv6, drone.ShortNameDrone, drone.Angle); break;
                        case 270: MoveLeft(movedata.Single(), drone.Ipv6, drone.ShortNameDrone); break;
                        case 315: MoveUp315(movedata.Single(), drone.Ipv6, drone.ShortNameDrone, drone.Angle); break;

                        default: break;
                    }

                    return new List<InformationDrone>();
                }

                return new List<InformationDrone>()
                {
                    new InformationDrone() { Id = 0 }
                };
            }
            catch
            {
                return new List<InformationDrone>();
            }
        }

        private void MoveDown135(int MaxMoveBlock, string IPv6, string ShortNameDron, int Angle)
        {
            if (_objectMove.Blocks <= MaxMoveBlock)
            {
                var updateData = connect.InformationDrones.FirstOrDefault(x => x.LoginUser == _objectMove.Login && x.Ipv6 == IPv6);

                long X = dataDrone.Select(x => x.X).FirstOrDefault();
                long Y = dataDrone.Select(x => x.Y).FirstOrDefault();

                
                X = updateData.X + _objectMove.Blocks;
                Y = updateData.Y - _objectMove.Blocks;
                

                updateData.X = X;
                updateData.Y = Y;

                connect.SaveChanges();
            }
        }
       
        private void MoveUp45(int MaxMoveBlock, string IPv6, string ShortNameDron, int Angle)
        {
            if (_objectMove.Blocks <= MaxMoveBlock)
            {
                var updateData = connect.InformationDrones.FirstOrDefault(x => x.LoginUser == _objectMove.Login && x.Ipv6 == IPv6);

                long X = dataDrone.Select(x => x.X).FirstOrDefault();
                long Y = dataDrone.Select(x => x.Y).FirstOrDefault();

                
                X = updateData.X + _objectMove.Blocks;
                Y = updateData.Y + _objectMove.Blocks;
                

                updateData.X = X;
                updateData.Y = Y;

                connect.SaveChanges();
            }
        }
        
        private void MoveDown225(int MaxMoveBlock, string IPv6, string ShortNameDron, int Angle)
        {
            if (_objectMove.Blocks <= MaxMoveBlock)
            {
                var updateData = connect.InformationDrones.FirstOrDefault(x => x.LoginUser == _objectMove.Login && x.Ipv6 == IPv6);

                long X = dataDrone.Select(x => x.X).FirstOrDefault();
                long Y = dataDrone.Select(x => x.Y).FirstOrDefault();

                X = updateData.X - _objectMove.Blocks;
                Y = updateData.Y - _objectMove.Blocks;

                updateData.X = X;
                updateData.Y = Y;

                connect.SaveChanges();
            }
        }

        private void MoveUp315(int MaxMoveBlock, string IPv6, string ShortNameDron, int Angle)
        {
            if (_objectMove.Blocks <= MaxMoveBlock)
            {
                var updateData = connect.InformationDrones.FirstOrDefault(x => x.LoginUser == _objectMove.Login && x.Ipv6 == IPv6);

                long X = dataDrone.Select(x => x.X).FirstOrDefault();
                long Y = dataDrone.Select(x => x.Y).FirstOrDefault();

                X = updateData.X - _objectMove.Blocks;
                Y = updateData.Y + _objectMove.Blocks;

                updateData.X = X;
                updateData.Y = Y;

                connect.SaveChanges();
            }
        }

        private void MoveDown(int MaxMoveBlock, string IPv6, string ShortNameDrone)
        {
            if (_objectMove.Blocks <= MaxMoveBlock)
            {
                var updateData = connect.InformationDrones.FirstOrDefault(x => x.LoginUser == _objectMove.Login && x.Ipv6 == IPv6);

                long X = dataDrone.Select(x => x.X).FirstOrDefault();

                X -= _objectMove.Blocks;

                updateData.X = X;

                connect.SaveChanges();
            }
        }

        private void MoveLeft(int MaxMoveBlock, string IPv6, string ShortNameDrone)
        {
            if (_objectMove.Blocks <= MaxMoveBlock)
            {
                var updateData = connect.InformationDrones.FirstOrDefault(x => x.LoginUser == _objectMove.Login && x.Ipv6 == IPv6);

                long Y = dataDrone.Select(x => x.Y).FirstOrDefault();

                Y -= _objectMove.Blocks;

                updateData.Y = Y;

                connect.SaveChanges();
            }
        }

        private void MoveRight(int MaxMoveBlock, string IPv6, string ShortNameDrone)
        {
            if (_objectMove.Blocks <= MaxMoveBlock)
            {
                var updateData = connect.InformationDrones.FirstOrDefault(x => x.LoginUser == _objectMove.Login && x.Ipv6 == IPv6);

                long Y = dataDrone.Select(x => x.Y).FirstOrDefault();

                Y += _objectMove.Blocks;

                updateData.Y = Y;

                connect.SaveChanges();
            }
        }

        private List<InformationDrone> MoveUp(int MaxMoveBlock, string IPv6, string ShortNameDron)
        {
            if (_objectMove.Blocks <= MaxMoveBlock)
            {
                var updateData = connect.InformationDrones.FirstOrDefault(x => x.LoginUser == _objectMove.Login && x.Ipv6 == IPv6);

                long X = dataDrone.Select(x => x.X).FirstOrDefault();

                X += _objectMove.Blocks;

                updateData.X = X;

                connect.SaveChanges();

                return KeyInfoAccept();
            }

            return KeyInfoFail();
        }

        private List<InformationDrone> KeyInfoAccept()
        {
            return connect.InformationDrones.Where(x => x.DroneShortName == _objectMove.ShortNameDrone && x.LoginUser == _objectMove.Login).ToList();
        }

        private List<InformationDrone> KeyInfoFail()
        {
            return new List<InformationDrone>()
            {

            };
        }
    }
}
