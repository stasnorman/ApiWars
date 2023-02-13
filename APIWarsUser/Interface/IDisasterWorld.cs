namespace APIWarsUser.Interface
{
    /// <summary>
    /// Интерфейс для получения данных об игровых бедствиях
    /// </summary>
    public interface IDisasterWorld
    {
        /// <summary>
        /// Информация о всех бедствиях в игре
        /// </summary>
        /// <returns>
        /// Возвращает массив объектов с полями: название и описание события
        /// </returns>
        public List<DisasterWorldDTO> GetDisasters();

        /// <summary>
        /// Информация об одном бедствии в игре
        /// </summary>
        /// <returns>
        /// Возвращает массив объектов с полями: название и описание бедствиях
        /// </returns>
        public List<DisasterWorldDTO> GetDisaster(string name);
    }
}
