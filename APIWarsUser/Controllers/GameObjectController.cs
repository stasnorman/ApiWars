namespace APIWarsUser.Controllers
{
    //[Authorize]
    [Route("api/hardware")]
    [ApiController]
    public class GameObjectController : ControllerBase
    {
            private readonly IGameObject _IGameObject;   
            
            public GameObjectController(IGameObject IGameObject) => _IGameObject = IGameObject;

            [HttpGet("servers")]
            [Produces("application/json")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            public async Task<ActionResult<IEnumerable<GameObjectDTO>>> Get() => await Task.FromResult(_IGameObject.GetServers());

            [HttpGet("servers/{name}")]
            [Produces("application/json")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            public async Task<ActionResult<List<GameObjectDTO>>> Get(string name)
                => await Task.FromResult(_IGameObject.GetServer(name));
    }
}