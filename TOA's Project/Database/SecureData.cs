using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TOA_s_Project.Database
{
    public class SecureData
    {
        public static string EncryptData(string password)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            byte[] passwordHash = Encoding.UTF8.GetBytes(password);
            return Encoding.UTF8.GetString(md5.ComputeHash(passwordHash));
        }
    }
}
