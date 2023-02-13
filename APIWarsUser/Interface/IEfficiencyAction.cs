namespace APIWarsUser.Interface
{
    /// <summary>
    /// Интерфейс для получения данных о способности класса дрона
    /// </summary>
    public interface IEfficiencyAction
    {
        /// <summary>
        /// Информация о всех способностях каждого класса дрона
        /// </summary>
        /// <returns>
        /// Возвращает массив объектов с полями: название, описание, единицы полезного действия
        /// </returns>
        public List<EfficiencyActionDTO> GetEfficiencyActions();

        /// <summary>
        /// Информация о способности класса дрона по её названию
        /// </summary>
        /// <returns>
        /// Возвращает массив объектов с полями:  название, описание, единицы полезного действия
        /// </returns>
        public List<EfficiencyActionDTO> GetEfficiencyAction(string name);
    }
}
