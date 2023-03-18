using System.Security.Cryptography;
using System.Text;

namespace Models.Services;

public  class HashingService:IHashingService
{
    private readonly Random _rnd = new();
    private readonly char[] _saltChars = new char[8];
    public string GenerateSalt()
    {
        for (var i = 0; i < _saltChars.Length; i++)
            _saltChars[i] = (char)_rnd.Next(33, 256);
        return string.Join("",_saltChars);
    }

    public string GenerateHash(string truePassword, string salt)
    {
        return Convert.ToHexString(MD5.HashData(Encoding.ASCII.GetBytes(truePassword+salt)));
    }
}