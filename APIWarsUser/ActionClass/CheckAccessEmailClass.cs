namespace APIWarsUser.ActionClass
{
    public class CheckAccessEmailClass
    {
        private string _email { get; set; }
        private readonly SpaceGameWorldContext _context;
        public CheckAccessEmailClass(string email, SpaceGameWorldContext context)
        {
            _email = email;
            _context = context;
        }

        /// <summary>
        /// Проверяем на существование подобного емейла внутри БД
        /// </summary>
        /// <returns>Возвращаем статус, true - не существует, false - совпадения найдено</returns>
        public bool IsEmailAccess()
        {
            if (_context.Accounts.Count(x => x.Email == _email) > 0) return false;
            else return true;
        }
    }
}