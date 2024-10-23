using System;
using System.Text;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma string para aplicar o hashing SHA256");
        string inputData = Console.ReadLine();
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