using System.Text.RegularExpressions;

namespace APIWarsUser.ActionClass
{
    public class ValidateEmailClass
    {
        private string _email { get; set; }
        public ValidateEmailClass(string email)
        {
            _email = email;
        }

        /// <summary>
        /// Проверка на соответствие с требованиям Емейла
        /// </summary>
        /// <returns>Возвращает данные: true - прошел, false - не прошел</returns>
        public bool isValid()
        {
            if (_email != null)
            {
                string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
                Match isMatch = Regex.Match(_email, pattern, RegexOptions.IgnoreCase);
                return isMatch.Success;
            }
            else
            {
                return false;
            }
        }
    }
}
