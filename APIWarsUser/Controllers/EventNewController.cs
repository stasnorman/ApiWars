using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWarsUser.Controllers
{
    [Authorize]
    [Route("api/")]
    [ApiController]
    public class EventNewController : ControllerBase
    {
        private readonly IEventNew _IEvent;
        public EventNewController(IEventNew IEvent) => _IEvent = IEvent;

        /// <summary>
        /// Получаем список событий
        /// </summary>
        /// <returns></returns>
        [HttpGet("events")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<EventNewDTO>>> Get() => await Task.FromResult(_IEvent.GetEvents());

        /// <summary>
        /// Получаем событие по названию
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Возвращает массив данных о событии по имени</returns>
        [HttpGet("events/{name}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<EventNewDTO>>> Get(string codeNumber) => await Task.FromResult(_IEvent.GetEvent(codeNumber));
    }
}
