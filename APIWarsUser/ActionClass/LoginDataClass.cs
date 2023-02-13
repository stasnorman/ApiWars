using Newtonsoft.Json;
using System.Net;

namespace APIWarsUser.ActionClass
{
    public class LoginDataClass : ILogin
    {
        private readonly SpaceGameWorldContext _context;

        public LoginDataClass(SpaceGameWorldContext context)
        {
            _context = context;
        }
        public List<AccountLoginDTO> GetAuth(AccountLogin _user)
        {
            try
            {
                var data = _context.Accounts.Select(
                    x => new AccountLoginDTO()
                    {
                        Email = x.Email,
                        Login = x.Login,
                        Name = x.Name,
                        BlackBoxKey = x.ApiKey
                    }
                    ).Where(z => z.Login == _user.Login).ToList();
                return data;

            }
            catch
            {
                throw;
            }
        }
    }
}
