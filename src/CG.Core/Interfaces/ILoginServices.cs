namespace CG.Core.Interfaces
{
    public interface ILoginServices
    {
        Task<string> connectDB();
        Task<string> Login(string username, string password);
    }
}
