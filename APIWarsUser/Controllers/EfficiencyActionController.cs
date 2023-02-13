using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWarsUser.Controllers
{
    [Authorize]
    [Route("api/satellite/skills")]
    [ApiController]
    public class EfficiencyActionController : ControllerBase
    {
        private readonly IEfficiencyAction _IEfficiencyDroneAction;
        public EfficiencyActionController(IEfficiencyAction IEfficiencyDroneAction) => _IEfficiencyDroneAction = IEfficiencyDroneAction;

        /// <summary>
        /// Получаем список действий способностей дронов
        /// </summary>
        /// <returns>
        /// Возвращает массив данных полезного действия дрона
        /// </returns>
        [HttpGet("effects")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<EfficiencyActionDTO>>> Get() => await Task.FromResult(_IEfficiencyDroneAction.GetEfficiencyActions());

        /// <summary>
        /// Получаем список действий дрона с параметрами по названию
        /// </summary>
        /// <param name="name"></param>
        /// <returns>
        /// Возвращает массив данных полезного действия дрона
        /// </returns>
        [HttpGet("effects/{name}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<EfficiencyActionDTO>>> Get(string name) => await Task.FromResult(_IEfficiencyDroneAction.GetEfficiencyAction(name));
    }
}
