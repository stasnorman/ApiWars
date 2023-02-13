
using APIWarsUser.ActionClass.HelperClass.World.DroneUser;
using APIWarsUser.ActionClass.HelperClass.World.Model;

namespace APIWarsUser.ActionClass
{
    public class CreateUserClass : ICreateUser
    {
        readonly SpaceGameWorldContext _context;

        private ConverterClassMD5? _convertToMD5;
        private ValidateEmailClass? _validateEmail;
        private CheckAccessEmailClass? _checkAccessEmailClass;

        public CreateUserClass(SpaceGameWorldContext context) => _context = context;

        /// <summary>
        /// Добавляет пользователя
        /// </summary>
        /// <param name="account">Принимает данные по объекту Account</param>
        /// <returns>Возвращаем статус регистрации: true - создан пользователь, false - не создан пользователь</returns>
        public bool AddAccount(AccountCreate account)
        {
            try
            {
                _convertToMD5 = new ConverterClassMD5(account.Password);
                _validateEmail = new ValidateEmailClass(account.Email);
                _checkAccessEmailClass = new CheckAccessEmailClass(account.Email, _context);
                string HashKey = new RandomString(10).GenerationWord();
                account.Login = account.Login.Replace(" ", "").ToString();

                if (_validateEmail.isValid() && _checkAccessEmailClass.IsEmailAccess())
                {
                    account.Password = _convertToMD5.CreateMD5();
                    var role = _context.Roles.ToArray();

                    Account accountInsert = new Account()
                    {
                        Name = account.Name,
                        Login = account.Login,
                        RoleName = role[1].Name,
                        Password = account.Password,
                        ApiKey = HashKey,
                        Email = account.Email
                    };
                    _context.Accounts.Add(accountInsert);
                    new AssignDroneUser(_context, account.Login);

                    AccountCreateRequest.Name = account.Name;
                    AccountCreateRequest.Login = account.Login;
                    AccountCreateRequest.RoleName = role[1].Name;
                    AccountCreateRequest.Email = account.Email;
                    AccountCreateRequest.SecretKey = HashKey;

                    return true;
                }
                
                else return false;
            }
            catch
            {
                Results.BadRequest();
                throw;
            }
        }

    }
}
