using System;
using System.Security.Cryptography;
using System.Text;

namespace WebApplication3.Services
{
    public class PasswordHasher
    {

        public byte[] Md5HashPassword(string password)
        {
            using (var md5 = MD5.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                return md5.ComputeHash(bytes);
            }
        }
    
        public string ToHex(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (var b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}