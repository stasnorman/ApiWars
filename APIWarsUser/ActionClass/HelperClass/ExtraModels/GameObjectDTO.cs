namespace APIWarsUser.ActionClass.HelperClass
{
    /// <summary>
    /// Объект передачи данных сервера
    /// </summary>
    /// <param name="ServerDTO"></param>
    /// <returns>Массив данных содержит инофрмацию о сервере</returns>
    public class GameObjectDTO
    {

        /// <summary>
        /// Нулевой элемент массива сервера
        /// </summary>
        /// <param name="Name"></param>
        /// <returns>Cодержит название сервера</returns>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Первый элемент массива сервера
        /// </summary>
        /// <param name="TypeObject"></param>
        /// <returns>Cодержит название типа сервера</returns>
        public string TypeObject{ get; set; } = null!;

        /// <summary>
        /// Второй элемент массива сервера
        /// </summary>
        /// <param name="Ip"></param>
        /// <returns>Cодержит IP адрес сервера</returns>
        public string Ipv6 { get; set; } = null!;

        /// <summary>
        /// Четвёртый элемент массива сервера
        /// </summary>
        /// <param name="StateObject"></param>
        /// <returns>Cодержит информацию о текущем состоянии сервера, ссылается на первичынй ключ из таблицы StateServer</returns>
        public string StateObject { get; set; } = null!;

        /// <summary>
        /// Третий элемент массива сервера
        /// </summary>
        /// <param name="HeatPoint"></param>
        /// <returns>Содержит уровень сервера, на данный момент от 1 до 3, целочисленный тип</returns>
        public int? HeatPoint { get; set; }


    }
}
