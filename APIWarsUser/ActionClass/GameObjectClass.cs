using APIWarsUser.ActionClass.HelperClass.ExtraModels;

namespace APIWarsUser.ActionClass
{
    public class GameObjectClass : IGameObject
    {
        private readonly SpaceGameWorldContext _context;
        public GameObjectClass(SpaceGameWorldContext context) => _context = context;



        /// <summary>
        /// Получение массива по id сервера
        /// </summary>
        /// <returns>Возвращает данные: массив сервера 
        /// или cообщает о возникновении исключения во время выполнения программы.</returns>
        public List<GameObjectDTO> GetServer(string name)
        {
            try
            {
                var data = _context.GameObjects.AsQueryable().Select(
                    serv => new GameObjectDTO()
                    {
                        Name = serv.Name,
                        TypeObject = serv.TypeObject,
                        Ipv6 = serv.Ipv6,
                        StateObject = serv.StateObject,
                        HeatPoint = serv.HeatPoint              
                    }).Where(servachok => servachok.Name == name);
            return data.ToList();
            }
            catch
            {
                Results.BadRequest();
                throw;
            }
        }

        /// <summary>
        /// Получение массива по серверам
        /// </summary>
        /// <returns>Возвращает данные: массив серверов или 
        /// cообщает о возникновении исключения во время выполнения программы.</returns>
        public List<GameObjectDTO> GetServers()
        {
            try
            {
                var data = _context.GameObjects.Select(
                    serv => new GameObjectDTO()
                    {
                        Name = serv.Name,
                        TypeObject = serv.TypeObject,
                        Ipv6 = serv.Ipv6,
                        StateObject = serv.StateObject,
                        HeatPoint = serv.HeatPoint
                    }
                            ).ToList();
                return data;
            }
            catch
            {
                Results.BadRequest();
                throw;
            }
        }
    }
}
