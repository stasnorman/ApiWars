namespace APIWarsUser.Controllers
{
    [Route("api/create")]
    [ApiController]
    public class CreateUserController : ControllerBase
    {
        private readonly ICreateUser _ICreateUser;
        public CreateUserController(ICreateUser ICreateUser)
        {
            _ICreateUser = ICreateUser;
        }

        /// <summary>
        /// Добавляет пользователя
        /// </summary>
        /// <param name="account">Обрабатывает данные и отправляет их в БД</param>
        /// <returns></returns>
        [HttpPost("add-player")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Account>> Post(AccountCreate account)
        {
            if (!_ICreateUser.AddAccount(account))
            {
                await Request.ReadFormAsync();
                return NotFound();
            }
            return Ok(
                    new
                        {
                            serialCode = AccountCreateRequest.SecretKey
                    }
                );
        }
    }
}
