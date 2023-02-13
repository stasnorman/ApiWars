using APIWarsUser.ActionClass.HelperClass.Enemy;

namespace APIWarsUser.Interface
{
    public interface INetScan
    {
        /// <summary>
        /// сканирование всей местности
        /// </summary>
        /// <returns>
        /// Возвращает массив объектов с полями по одной очке: идентификатор, координаты по осям, возможные события и происшествия
        /// </returns>
        public List<NetScanDTO> GetInfoNow(AccountData account);    
        public List<Information> GetEnemy(AccountData account);
    }
}
