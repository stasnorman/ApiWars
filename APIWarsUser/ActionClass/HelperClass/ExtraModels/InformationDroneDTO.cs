namespace APIWarsUser.ActionClass.HelperClass.ExtraModels
{
    /// <summary>
    /// Объект передачи данных по уникальным дронам, которые генерируются для игроков из существующих в игровом мире 
    /// </summary>
    /// <param name="InformationDroneDTO"></param>
    /// <returns>
    /// Массив данных, который содержит инофрмацию: идентификатор дрона, координаты, IPv6 и игровое название дрона
    /// </returns>
    public class InformationDroneDTO
    {
        /// <summary>
        /// Нулевой элемент массива дронов
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>содержит идентификатор дрона
        /// </returns>
        public long Id { get; set; }

        /// <summary>
        /// Первый элемент массива дронов
        /// </summary>
        /// <param name="X"></param>
        /// <returns>содержит координату дрона на оси абсцисс
        /// </returns>
        public long X { get; set; }

        /// <summary>
        /// Второй элемент массива дронов
        /// </summary>
        /// <param name="Y"></param>
        /// <returns>содержит координату дрона на оси ординат
        /// </returns>
        public long Y { get; set; }

        /// <summary>
        /// Третий элемент массива дронов
        /// </summary>
        /// <param name="Ipv6"></param>
        /// <returns>содержит адрес IP адрес дрона
        /// </returns>
        public string Ipv6 { get; set; } = null!;

        /// <summary>
        /// Четвёртый элемент массива дронов
        /// </summary>
        /// <param name="DroneName"></param>
        /// <returns>содержит название дрона
        /// </returns>
        public string DroneName { get; set; } = null!;
        
        /// <summary>
        /// Четвёртый элемент массива дронов
        /// </summary>
        /// <param name="LoginUser"></param>
        /// <returns>содержит логин владельца дрона
        /// </returns>
        public string LoginUser { get; set; } = null!;


    }
}