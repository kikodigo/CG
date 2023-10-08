using CG.Core.Services.Interfaces;
using CG.Repository.Interfaces;

namespace CG.Core.Services
{
    public class LoginServices : ILoginServices
    {
        private readonly ILoginRepository _loginRepository;

        public LoginServices(
            ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
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
