using APIWarsUser.ActionClass.HelperClass.Enemy;

namespace APIWarsUser.ActionClass.HelperClass.ExtraModels
{
    /// <summary>
    /// Объект передачи данны для сканера местности
    /// </summary>
    /// <param name="NetScanDTO"></param>
    /// <returns>Массив сканера состоит из данных координат, наличия в этих координатах игрового объекта, происшествия события или бедствия</returns>
    public class NetScanDTO: GameObject
    {

        public string Name { get; set; }
        public long X { get; set; }
        public long Y { get; set; }
        public int? HeatPoint { get; set; }
        public string TypeObject { get; set; }
        public string IPv6 { get; set; }
        public string Status { get; set; }
        public string PlanetName { get; set; } = null!;
        public long DroneId { get; set; }
    }

}
