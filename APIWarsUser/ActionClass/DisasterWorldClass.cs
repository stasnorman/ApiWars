namespace APIWarsUser.ActionClass
{
    /// <summary>
    /// Класс обработки данных игровых бедствий
    /// </summary>
    public class DisasterWorldClass : IDisasterWorld
    {
        private readonly SpaceGameWorldContext _context;
        public DisasterWorldClass(SpaceGameWorldContext context) => _context = context;

        /// <summary>
        /// Получение массива по названию бедствия
        /// </summary>
        /// <returns>Массив с данными бедствия
        /// или cообщает о возникновении исключения во время выполнения программы.</returns>
        public List<DisasterWorldDTO> GetDisaster(string name)
        {
            try
            {

                var data = _context.DisasterWorlds.AsQueryable().Select(
                        dis => new DisasterWorldDTO()
                        {
                            Name = dis.Name,
                            Body = dis.Body,
                        }).Where(di => di.Name == name);
                return data.ToList();
            }
            catch
            {
                Results.BadRequest();
                throw;
            }
        }

        /// <summary>
        /// Получение массива по бедствия
        /// </summary>
        /// <returns>Массив с данными всех бедствий
        /// или cообщает о возникновении исключения во время выполнения программы.</returns>
        public List<DisasterWorldDTO> GetDisasters()
        {
            try
            {
                var data = _context.DisasterWorlds.Select(
                    dis => new DisasterWorldDTO()
                    {
                        Name = dis.Name,
                        Body = dis.Body,
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
