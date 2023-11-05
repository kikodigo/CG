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

        public bool StatusDb()
        {
            var result = _loginRepository.StatusDb();

            return result == System.Data.ConnectionState.Open;
        }


        public bool Login(string username, string password)
        {
            var result = _loginRepository.Login(username, password);

            return !string.IsNullOrEmpty(result);
        }
    }
}
