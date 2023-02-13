using System.Linq;

namespace APIWarsUser.ActionClass
{
    public class DroneClass : IDrone
    {
        private readonly SpaceGameWorldContext _context;
        public DroneClass(SpaceGameWorldContext context) => _context = context;

        /// <summary>
        ///     Получение массива дрона по его короткому названию
        /// </summary>
        /// <returns>
        /// Возвращает данные: массив данных о дроне или cообщает о возникновении исключения во время выполнения программы.
        /// </returns>
        public List<Drone> GetDrone(string name)
        {
            try
            {
                var data = _context.Drones.Where(d => d.ShortName == name);
                return data.ToList();
            }
            catch (Exception)
            {
                Results.BadRequest();
                throw;
            }
        }


        /// <summary>
        /// Получение массива дронов
        /// </summary>
        /// <returns>массив дронов
        /// или cообщает о возникновении исключения во время выполнения программы.</returns>
        public List<Drone> GetDrones()
        {
            try
            {
                var data = _context.Drones.ToList();
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
