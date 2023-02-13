

namespace APIWarsUser.Controllers
{
    [Route("api/sign-in")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly ILogin _ILogin;
        public LoginController(ILogin ILogin) => _ILogin = ILogin;


        [HttpPost]
        public async Task<ActionResult<List<AccountLoginDTO>>> Post(AccountLogin info)
        => await Task.FromResult(_ILogin.GetAuth(info));
    }
}
