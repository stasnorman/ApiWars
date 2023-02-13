namespace APIWarsUser.Controllers
{
    [Route("api/get-token")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly SpaceGameWorldContext? _context;
        public TokenController(IConfiguration config, SpaceGameWorldContext context)
        {
            _configuration = config;
            _context = context;
        }

        /// <summary>
        /// Генерация уникального токена пользователя
        /// </summary>
        /// <param name="_userData">Принимает логин и пароль пользователя</param>
        /// <returns>Возвращает Bearer-токен и статус</returns>
        [HttpPost]
        public async Task<IActionResult> Post(AccountGetToken _userData)
        {

            if (_userData.Password != null && _userData.Login != null)
            {
                var user = await GetUser(_userData.Login, _userData.Password);

                if (user != null)
                {
                    var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("name", user.Name),
                        new Claim("login", user.Login),
                        new Claim("email", user.Email),
                        new Claim("role", user.RoleName)
                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddDays(1),
                        signingCredentials: signIn);
                    string tokenUser = new JwtSecurityTokenHandler().WriteToken(token);
                    return Ok(tokenUser);
                }
                else
                {
                    return BadRequest("Данные неверны. Повторите авторизацию.");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Получение данных для генерации токена
        /// </summary>
        /// <param name="login">Введите логин пользователя</param>
        /// <param name="password">Введите пароль пользователя</param>
        /// <returns>Возвращает коллекцию по пользователю</returns>
        private async Task<Account> GetUser(string login, string password) => await _context.Accounts.FirstOrDefaultAsync(u => u.Login == login && u.Password == new ConverterClassMD5(password).CreateMD5());
        
    }
}
