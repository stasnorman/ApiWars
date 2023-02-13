namespace APIWarsUser.Interface
{
    /// <summary>
    /// Создание пользователя
    /// </summary>
    public interface ICreateUser
    {
        /// <summary>
        /// Добавление пользователя
        /// </summary>
        /// <param name="account">Принимает объект</param>
        /// <returns>Возвращает статус</returns>
        public bool AddAccount(AccountCreate account);
    }
}
