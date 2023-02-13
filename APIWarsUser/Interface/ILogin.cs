namespace APIWarsUser.Interface
{
    public interface ILogin
    {
        public List<AccountLoginDTO> GetAuth(AccountLogin _user);
    }
}
