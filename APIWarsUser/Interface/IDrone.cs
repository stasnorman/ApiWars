namespace APIWarsUser.Interface
{
    /// <summary>
    /// Интерфейс для получения внутриигровых дронов с названием и типом дрона
    /// </summary>
    public interface IDrone
    {
        /// <summary>
        /// Информация по всем дронам которыми могут владеть игроки
        /// </summary>
        /// <returns>Возвращает массив объектов с полями: с названием дрона и его типом</returns>
        public List<Drone> GetDrones();

        /// <summary>
        /// Информация о дроне по его названию
        /// </summary>
        /// <returns>Возвращает массив объектов с полями по одному дрону: название и его тип</returns>
        public List<Drone> GetDrone(string name);
    }
}
