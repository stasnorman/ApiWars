using APIWarsUser.ActionClass.HelperClass.Enemy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWarsUser.Controllers
{
    [Route("api/")]
    [ApiController]
    public class NetScanController : ControllerBase
    {
        private readonly INetScan _INetScan;
        public NetScanController(INetScan INetScan) => _INetScan = INetScan;

        [HttpPost("netscan/object")]
        [Produces("application/json")]

        public async Task<ActionResult<IEnumerable<NetScanDTO>>> GetObject(AccountData account) => await Task.FromResult(_INetScan.GetInfoNow(account));

        [HttpPost("netscan/enemy")]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<Information>>> GetEnemy(AccountData account) => await Task.FromResult(_INetScan.GetEnemy(account));
    }
}
