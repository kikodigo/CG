namespace CG.Core.Services.Interfaces
{
    public interface ILoginServices
    {
        Task<string> connectDB();
        Task<bool> Login(string username, string password);
    }
}
