using APIWarsUser.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWarsUser.Controllers
{
    [Route("api/")]
    [ApiController]
    public class HelpController : ControllerBase
    {

        [HttpGet("help")]
        public ActionResult Get() {

            return Ok(
                    new {
                        move = "/move-list",
                        action = "/move-list",
                        attack = "/move-list",
                        repeare = "/move-list",
                        monitor = "/move-list"
                    }
                );


        } 


    }
}
