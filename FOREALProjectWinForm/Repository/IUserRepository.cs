namespace FOREALProjectWinForm
{
    public interface IUserRepository
    {
        bool ValidateUser(string username, string password);
    }
}
