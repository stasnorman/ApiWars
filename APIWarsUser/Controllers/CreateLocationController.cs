using APIWarsUser.ActionClass.HelperClass.World.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWarsUser.Controllers
{
    [Route("api/create")]
    [ApiController]
    public class CreateLocationController : ControllerBase
    {
        private readonly ICreateLocation ICreateLoc;
        public CreateLocationController(ICreateLocation _createLocation)
        {
            ICreateLoc = _createLocation;
        }

        [HttpPost("location")]
        public async Task<IActionResult> Post(int server_count)
        {
            if (!ICreateLoc.Generation(server_count)) {
                await Request.ReadFormAsync();
                return BadRequest();
            }
            return Ok();
        }
    }
}
