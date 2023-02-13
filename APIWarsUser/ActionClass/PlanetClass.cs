namespace APIWarsUser.ActionClass
{
    /// <summary>
    /// Класс обработки данных планет
    /// </summary>
    public class PlanetClass : IPlanet
    {
        private readonly SpaceGameWorldContext _context;
        public PlanetClass(SpaceGameWorldContext context) => _context = context;

        /// <summary>
        /// Получение массива по названию планеты
        /// </summary>
        /// <returns>Массив с данными планеты
        /// или cообщает о возникновении исключения во время выполнения программы.</returns>
        public List<PlanetDTO> GetPlanet(string name)
        {
            try
            {

                var data = _context.Planets.AsQueryable().Select(
                        pla => new PlanetDTO()
                        {
                            Name = pla.Name,
                            Description = pla.Description,
                            Square = pla.Square,
                            Latitude = pla.Latitude,
                            Longitude = pla.Longitude,
                        }).Where(pl => pl.Name == name);
                return data.ToList();
            }
            catch
            {
                Results.BadRequest();
                throw;
            }
        }

        /// <summary>
        /// Получение массива игровых планет
        /// </summary>
        /// <returns>Массив с данными всех планет
        /// или cообщает о возникновении исключения во время выполнения программы.</returns>
        public List<PlanetDTO> GetPlanets()
        {
            try
            {
                var data = _context.Planets.Select(
                    pla => new PlanetDTO()
                    {
                        Name = pla.Name,
                        Description = pla.Description,
                        Square = pla.Square,
                        Latitude = pla.Latitude,
                        Longitude = pla.Longitude,
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
