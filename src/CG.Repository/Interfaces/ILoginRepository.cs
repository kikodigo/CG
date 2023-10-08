namespace CG.Repository.Interfaces
{
    public interface ILoginRepository
    {
        Task<string> conectDb();
        Task<string> Login(string username, string password);
    }
}
