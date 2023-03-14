using System.Security.Cryptography;
using System.Text;

namespace Models.Services;

public  class HashingService:IHashingService
{
    private readonly Random Rnd = new();
    private readonly char[] SaltChars = new char[8];
    public string GenerateSalt()
    {
        for (int i = 0; i < SaltChars.Length; i++)
            SaltChars[i] = (char)Rnd.Next(33, 256);
        return string.Join("",SaltChars);
    }

    public string GenerateHash(string truePassword, string salt)
    {
        return Convert.ToHexString(MD5.HashData(Encoding.ASCII.GetBytes(truePassword+salt)));
    }
}