namespace APIWarsUser.ActionClass
{
    /// <summary>
    /// Класс обработки данных игровых событий
    /// </summary>
    public class EventNewClass : IEventNew
    {
        private readonly SpaceGameWorldContext _context;
        public EventNewClass(SpaceGameWorldContext context) => _context = context;

        /// <summary>
        /// Получение массива данных одного события
        /// </summary>
        /// <returns>Массив с данными об одном игровом событии
        /// или cообщает о возникновении исключения во время выполнения программы.</returns>
        public List<EventNewDTO> GetEvent(string codeNumber)
        {
            try
            {

                var data = _context.EventNews.AsQueryable().Select(
                        e => new EventNewDTO()
                        {
                            CodeNumber = e.CodeNumber,
                            Body = e.Body,
                            DisasterWorldName = e.DisasterWorldName
                        }).Where(ev => ev.CodeNumber == codeNumber);
                return data.ToList();
            }
            catch
            {
                Results.BadRequest();
                throw;
            }
        }

        /// <summary>
        /// Получение массива всех игровых событий
        /// </summary>
        /// <returns>Возвращает данные: массив с данными всех игровых событий
        /// или cообщает о возникновении исключения во время выполнения программы.</returns>
        public List<EventNewDTO> GetEvents()
        {
            try
            {
                var data = _context.EventNews.Select(
                    e => new EventNewDTO()
                    {
                        CodeNumber = e.CodeNumber,
                        Body = e.Body,
                        DisasterWorldName = e.DisasterWorldName
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
