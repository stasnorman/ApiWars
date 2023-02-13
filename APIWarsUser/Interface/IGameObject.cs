namespace APIWarsUser.Interface
{
    /// <summary>
    /// Интерфейс для получения данных о сервере
    /// </summary>
    public interface IGameObject
    {
        /// <summary>
        /// Информация о всех серверах
        /// </summary>
        /// <returns>
        /// Возвращает массив объектов с полями: идентификатор, название, тип, ip, местонахождение, уровень, показатели и текущий статус
        /// </returns>
        public List<GameObjectDTO> GetServers();

        /// <summary>
        /// Информация об одном сервере
        /// </summary>
        /// <returns>
        /// Возвращает массив объектов с полями: идентификатор, название, тип, ip, местонахождение, уровень, показатели и текущий статус
        /// </returns>
        public List<GameObjectDTO> GetServer(string name);
    }
}
