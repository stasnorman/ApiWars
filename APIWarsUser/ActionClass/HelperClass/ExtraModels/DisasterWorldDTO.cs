namespace APIWarsUser.ActionClass.HelperClass.ExtraModels
{   
    /// <summary>
    /// Объект передачи даных сущности DisasterWorld 
    /// </summary>
    public class DisasterWorldDTO
    {
        /// <summary>
        /// Название бедствия
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Описание
        /// </summary>
        public string Body { get; set; } = null!;
    }
}
