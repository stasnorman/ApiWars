namespace APIWarsUser.Interface
{    
     /// <summary>
     /// Ресурсы игрока
     /// </summary>
    public interface IResources
    {
        /// <summary>
        /// Получение инвентаря
        /// </summary>
        /// <param name="resourcesKey">Принимает ApiKey</param>
        /// <returns>Возвращает статус</returns>
        public IQueryable<AccountResources> GetResources(string resourcesKey);
    }
}
