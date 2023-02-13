using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWarsUser.Controllers
{
    [Authorize]
    [Route("api/")]
    [ApiController]
    public class DisasterWorldController : ControllerBase
    {
        private readonly IDisasterWorld _IDisaster;
        public DisasterWorldController(IDisasterWorld IDisaster) => _IDisaster = IDisaster;

        /// <summary>
        /// Получаем список бедствий
        /// </summary>
        /// <returns></returns>
        [HttpGet("disasters")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DisasterWorldDTO>>> Get() => await Task.FromResult(_IDisaster.GetDisasters());

        /// <summary>
        /// Получаем бедствие по названию
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Возвращает массив данных о бедствии по имени</returns>
        [HttpGet("disasters/{name}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<DisasterWorldDTO>>> Get(string name) => await Task.FromResult(_IDisaster.GetDisaster(name));
    }
}
