using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class Cryptography
    {
       public static string Encrypt(string content)
        {
            using (SHA512 hashManager = new SHA512Managed())
            {
                byte[] hash = hashManager.ComputeHash(Encoding.UTF8.GetBytes(content));
                return Convert.ToBase64String(hash);
            }
        }
    }
}
