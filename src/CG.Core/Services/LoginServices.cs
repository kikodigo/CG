using CG.Repository.Repositories;

namespace CG.Core.Services
{
    public class LoginServices 
    {
        private readonly LoginRepository _loginRepository;

        public LoginServices()
        {
            _loginRepository = new LoginRepository();
        }

        public async Task<string> connectDB()
        {
            var result = await _loginRepository.Login("", "");

            return "";
        }


        public async Task<bool> Login(string username, string password)
        {
            var result = await _loginRepository.Login(username, password);

            return !string.IsNullOrEmpty(result);
        }
    }
}
