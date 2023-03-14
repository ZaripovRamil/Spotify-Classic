using System.Security.Cryptography;
using System.Text;

namespace Models.Services;

public static class HashingService
{
    private static readonly Random Rnd = new();
    private static readonly char[] SaltChars = new char[8];
    public static string GenerateSalt()
    {
        for (int i = 0; i < SaltChars.Length; i++)
            SaltChars[i] = (char)Rnd.Next(33, 256);
        return string.Join("",SaltChars);
    }

    public static string GenerateHash(string truePassword, string salt)
    {
        return Convert.ToHexString(MD5.HashData(Encoding.ASCII.GetBytes(truePassword+salt)));
    }
}