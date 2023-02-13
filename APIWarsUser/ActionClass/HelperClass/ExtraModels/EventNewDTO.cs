namespace APIWarsUser.ActionClass.HelperClass.ExtraModels
{
    /// <summary>
    ///     Объект передачи данных по каждому событию
    /// </summary>
    public class EventNewDTO
    {
        /// <summary>
        /// Кодовый номер по котормоу можно индексировать данные
        /// </summary>
        /// <params name="CodeNumber"></params>
        /// <returns>
        ///     Начинается с первой буквы названия планеты и содежрит три цифры статуса
        /// </returns>

        public string CodeNumber { get; set; } = null!;
        /// <summary>
        /// Тело события игрового события
        /// </summary>
        /// <params name="Body"></params>
        /// <returns>
        ///     Полезная информация для пользователей
        /// </returns>
        public string Body { get; set; } = null!;

        /// <summary>
        ///     Ссылка на PK Disaster world
        /// </summary>
        /// <params name="DisasterWorldName"></params>
        /// <returns>
        ///     ....
        /// </returns>
        public string? DisasterWorldName { get; set; }
    }
}
