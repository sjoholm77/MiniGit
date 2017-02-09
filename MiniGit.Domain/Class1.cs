using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiniGit.Domain
{
    public class Class1
    {
        public string AStart(string toHash)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(toHash);
            SHA1 sha = new SHA1CryptoServiceProvider();
            return ByteArrayToString(sha.ComputeHash(bytes));
        }

        public static string ByteArrayToString(byte[] ba)
        {
            var hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
    }
}
