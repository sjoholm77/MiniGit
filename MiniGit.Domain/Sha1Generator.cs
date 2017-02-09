using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace MiniGit.Domain
{
    public class Sha1Generator
    {
        public string GenerateHash(Stream stream)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();
            return ByteArrayToString(sha.ComputeHash(stream));
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