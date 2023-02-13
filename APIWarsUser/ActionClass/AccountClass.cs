namespace APIWarsUser.ActionClass
{
    public class AccountClass : IAccount
    {
        private readonly SpaceGameWorldContext _context;

        public AccountClass(SpaceGameWorldContext context) => _context = context;


        /// <summary>
        /// Вывод данных по логину
        /// </summary>
        /// <param name="login">Введите логин</param>
        /// <returns></returns>
        public List<AccountDto> GetAccountDetail(string login)
        {
            try
            {
                var data = _context.Accounts.Select(
                   x => new AccountDto()
                   {
                       Email = x.Email,
                       Login = x.Login,
                       Name = x.Name,
                       RoleName = x.RoleName
                   }
                   ).Where(u => u.Login == login).ToList();
                return (List<AccountDto>)data;


            }
            catch
            {
                Results.BadRequest();
                throw;
            }
        }

        /// <summary>
        /// Вывод всех пользователей
        /// </summary>
        /// <returns>Возвращает всех пользователей</returns>
        public List<AccountDto> GetAccountDetails()
        {
            try
            {
                var data = _context.Accounts.Select(
                    x => new AccountDto()
                    {
                        Email = x.Email,
                        Login = x.Login,
                        Name = x.Name,
                        RoleName = x.RoleName
                    }
                    ).ToList();
                return data;
            }
            catch
            {
                Results.BadRequest();
                throw;
            }
        }
    }
}
