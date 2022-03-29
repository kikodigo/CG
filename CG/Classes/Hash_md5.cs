using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GetPass.Classes
{
    public class Hash_md5
    {
        public static string GerarHash(string valor)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(valor));
            byte[] resultado = md5.Hash;
            StringBuilder str = new StringBuilder();
            for(int i =1;i<resultado.Length; i++)
            {
                str.Append(resultado[i].ToString("x2"));
            }
            return str.ToString();
        }
    }
}
