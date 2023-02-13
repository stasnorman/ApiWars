using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWarsUser.Controllers
{
    [Authorize]
    [Route("api/")]
    [ApiController]
    public class DroneController : ControllerBase
    {
        private readonly IDrone _IDrone;
        public DroneController(IDrone IDrone) => _IDrone = IDrone;

        /// <summary>
        /// Получаем дронов с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <returns>
        /// Возвращает массив данных о всех игровых дронах по названию
        /// </returns>
        [HttpGet("satellite")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Drone>>> Get() => await Task.FromResult(_IDrone.GetDrones());

        /// <summary>
        /// Получаем дрона с параметрами по названию
        /// </summary>
        /// <param name="name"></param>
        /// <returns>
        /// Возвращает массив данных о дроне по названию
        /// </returns>
        [HttpGet("satellite/{shortName}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<Drone>>> Get(string shortName) => await Task.FromResult(_IDrone.GetDrone(shortName));
    }
}
