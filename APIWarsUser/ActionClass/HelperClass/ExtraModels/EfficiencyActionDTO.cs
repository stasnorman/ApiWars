namespace APIWarsUser.ActionClass.HelperClass
{
    /// <summary>
    /// Объект передачи данных по полезному действию класса дрона
    /// EfficiencyAction
    /// </summary>
    /// <param name="EfficiencyDroneAction"></param>
    /// <returns>Набор всех навыков одного класса дрона</returns>
    public class EfficiencyActionDTO
    {
        /// <summary>
        /// Нулевой элемент массива
        /// </summary>
        /// <param name="Name"></param>
        /// <returns>Название способности дрона</returns>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Первый элемент массива
        /// </summary>
        /// <param name="Description"></param>
        /// <returns>Описание способности дрона</returns>
        public string Description { get; set; } = null!;

        /// <summary>
        /// Второй элемент массива
        /// </summary>
        /// <param name="ValueAction"></param>
        /// <returns>Полезное действие дрона плавающим значением 10,2</returns>
        public decimal ValueAction { get; set; }
    }
}
