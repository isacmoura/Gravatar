using System.Security.Cryptography;
using System.Text;

namespace Gravatar
{
    public static class GravatarExtension
    {
        public static string ToGravatar(this string email) {
            var baseUrl = "https://www.gravatar.com/avatar";
            if(string.IsNullOrEmpty(email))
                return string.Empty;
            
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(email);
            var hashBytes = md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            foreach (var b in hashBytes)
                sb.Append(b.ToString("X2"));

            return $"{baseUrl}/{sb.ToString().ToLower()}";
        }
    }
}
