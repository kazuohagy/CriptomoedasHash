using System;
using System.Text;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        string inputData = "Dados de exemplo";
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputData));
            StringBuilder hash = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                hash.Append(hashBytes[i].ToString("x2"));
            }
            Console.WriteLine($"Hash gerado: {hash}");
        }
    }
}