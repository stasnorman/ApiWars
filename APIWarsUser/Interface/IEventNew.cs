namespace APIWarsUser.Interface
{
    /// <summary>
    /// Интерфейс для получения данных об игровых событиях 
    /// </summary>
    public interface IEventNew
    {
        /// <summary>
        /// Информация о всех событиях в игре
        /// </summary>
        /// <returns>
        /// Возвращает массив объектов с полями: название и описание события
        /// </returns>
        public List<EventNewDTO> GetEvents();

        /// <summary>
        /// Информация об одном событии в игре
        /// </summary>
        /// <returns>
        /// Возвращает массив объектов с полями: название и описание события
        /// </returns>
        public List<EventNewDTO> GetEvent(string codeNumber);
    }
}
