using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWarsUser.Controllers
{
    [Authorize]
    [Route("api/satellite")]
    [ApiController]
    public class DroneSkillsController : ControllerBase
    {
        private readonly IDroneSkills _IDroneSkills;
        public DroneSkillsController(IDroneSkills IDroneSkills) => _IDroneSkills = IDroneSkills;

        /// <summary>
        /// Получаем все способности дронов
        /// </summary>
        /// <returns>
        /// Возвращает массив данных о всех способностях дронов
        /// </returns>
        [HttpGet("skills")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<DroneSkillsSet>>> Get() => await Task.FromResult(_IDroneSkills.GetSkills());

        /// <summary>
        /// Получаем способности дрона
        /// </summary>
        /// <param name="shortName"></param>
        /// <returns>
        /// Возвращает массив данных о всех способностях дрона по названию
        /// </returns>
        [HttpGet("skills/{shortName}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<DroneSkillsSet>>> Get(string shortName) => await Task.FromResult(_IDroneSkills.GetSkill(shortName));
    }
}
