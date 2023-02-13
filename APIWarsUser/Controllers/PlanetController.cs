using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWarsUser.Controllers
{
    [Authorize]
    [Route("api/")]
    [ApiController]
    public class PlanetController : ControllerBase
    {
        private readonly IPlanet _IPlanet;
        public PlanetController(IPlanet IPlanet) => _IPlanet = IPlanet;

        /// <summary>
        /// Получаем список планет
        /// </summary>
        /// <returns>Возвращает массив данных о планете по названию</returns>
        [HttpGet("planets")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PlanetDTO>>> Get() => await Task.FromResult(_IPlanet.GetPlanets());

        /// <summary>
        /// Получаем планету по названию
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Возвращает массив данных о планете по названию</returns>
        [HttpGet("planets/{name}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<PlanetDTO>>> Get(string name) => await Task.FromResult(_IPlanet.GetPlanet(name));
    }
}
