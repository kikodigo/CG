using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG.Repository.Config
{
    public class ConnectionStringConfig
    {
        internal static string CsSecretGest { get; }

        static ConnectionStringConfig()
        {
            CsSecretGest = Environment.GetEnvironmentVariable("csSecretGest");
        }
    }
}
