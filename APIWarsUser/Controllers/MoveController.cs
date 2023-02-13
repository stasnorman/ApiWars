using APIWarsUser.ActionClass.HelperClass.Drone;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWarsUser.Controllers
{   
    [Authorize]
    [Route("api/move")]
    [ApiController]
    public class MoveController : ControllerBase
    {
        private readonly IMove _IMove;

        public MoveController(IMove IMove)
        {
            _IMove = IMove;
        }

        [HttpPost("drone")]
        public async Task<ActionResult<IEnumerable<InformationDrone>>> Post(ObjectMove drone) => await Task.FromResult(_IMove.MoveDrone(drone));
    }
}

