namespace APIWarsUser.Interface
{
    /// <summary>
    /// Интерфейс для получения данных о пользователях
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Информация по всем пользователям
        /// </summary>
        /// <returns>Возвращает массив объектов с полями: Имя, Логин, Почта, Роль пользователя</returns>
        public List<AccountDto> GetAccountDetails();
        
        /// <summary>
        /// Информация по одному пользователю
        /// </summary>
        /// <param name="login">Введите логин</param>
        /// <returns>Возвращает объект: Имя, Логин, Почта, Роль пользователя</returns>
        public List<AccountDto> GetAccountDetail(string login);     

    }
}
