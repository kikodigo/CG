using CG.Controllers.Interface;
using CG.Core.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace CG.Controllers
{
    public class LoginControllers : ILoginControllers
    {

        private readonly ILoginServices _loginServices;

        public LoginControllers(
            ILoginServices loginServices)
        {
            _loginServices = loginServices;
        }

        public string ConectStatus()
        {
            return _loginServices.connectDB().Result;
        }

        public string Login(string username, string password) 
        {          
            return _loginServices.Login(username, password).Result;
        }
     
    }
}
