using APIWarsUser.ActionClass.HelperClass.World.DroneUser;

namespace APIWarsUser.ActionClass
{
    public class CreateLocationClass : ICreateLocation
    {
        private readonly SpaceGameWorldContext _spaceGameWorldContext;
        public CreateLocationClass(SpaceGameWorldContext context)
        {
            _spaceGameWorldContext = context;
        }

        public bool Generation(int server_count)
        {
            int i = 0;
            while (i < server_count)
            {
            kek:
                string code = new RandomString(4).GenerationWord().ToUpper();
                var ipv6 = new GenerationIpv6(1).GenerationIP();
                if (_spaceGameWorldContext.GameObjects.Count(x => x.Name == code) > 0)
                    goto kek;
                else
                {
                    var gameObject = new GameObject()
                    {
                        Name = code,
                        TypeObject = "Сервер",
                        Ipv6 = ipv6.ToArray().First(),
                        StateObject = "Нейтрален",
                        HeatPoint = new Random().Next(400, 1000)
                    };

                    _spaceGameWorldContext.GameObjects.Add(gameObject);
                    _spaceGameWorldContext.SaveChanges();
                    new AssignGameObjectXY(_spaceGameWorldContext, gameObject.Id);
                        
                    
                    i++;
                }
            }
            return true;
        }
    }
}
