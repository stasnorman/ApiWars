namespace APIWarsUser.Controllers
{
    [Authorize]
    [Route("api/control/")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccount _IAccount;
        public AccountController(IAccount IAccount)
        {
            _IAccount = IAccount;
        }

        /// <summary>
        /// Получаем список всех пользователей
        /// </summary>
        /// <returns></returns>
        [HttpGet("all-users")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<AccountDto>>> Get() => await Task.FromResult(_IAccount.GetAccountDetails());

        /// <summary>
        /// Получаем информацию по одному пользователю
        /// </summary>
        /// <param name="login"></param>
        /// <returns>Возвращает массив по одному пользователю через логин</returns>
        [HttpGet("{login}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<AccountDto>>> Get(string login)
            => await Task.FromResult(_IAccount.GetAccountDetail(login));


    }
}
