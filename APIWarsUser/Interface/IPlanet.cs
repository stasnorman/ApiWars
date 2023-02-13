namespace APIWarsUser.Interface
{
    /// <summary>
    /// Интерфейс для получения данных о планетах
    /// </summary>
    public interface IPlanet
    {
        /// <summary>
        /// Информация о всех планетах
        /// </summary>
        /// <returns>
        /// Возвращает массив объектов с полями: название планеты, описание, площадь, широта и долгота
        /// </returns>
        public List<PlanetDTO> GetPlanets();

        /// <summary>
        /// Информация об одной планете по названию 
        /// </summary>
        /// <returns>
        /// Возвращает массив объектов с полями: название планеты, описание, площадь, широта и долгота
        /// </returns>
        public List<PlanetDTO> GetPlanet(string name);
    }
}
