using Cryptography;
using System;

namespace CryptographyConsole
{
    class Program
    {
        static string path = @"C:\Users\Luis\Documents\Repository\Cryptography\Cryptography\Keys";

        static void Main(string[] args)
        {
            RSAImplement();
            AESImplement();
        }

        static void RSAImplement() 
        {
            RSAClient rsaClient = new RSAClient();
            rsaClient.GenerateKeys(path);
            rsaClient.LoadKeys(path, "PrivateKey.rsa");

            string dataToEncrypt = "Test";
            string dataEncrypt = rsaClient.Encrypt(dataToEncrypt);
            Console.WriteLine(dataToEncrypt);
            Console.WriteLine(dataEncrypt);

            string dataDecrypt = rsaClient.Decrypt(dataEncrypt);
            Console.WriteLine(dataEncrypt);
            Console.WriteLine(dataDecrypt);

        }

        static void AESImplement() 
        {
            AESClient aesClient = new AESClient();
            aesClient.GenerateKeys(path);
            aesClient.LoadKeys(path);

            string dataToEncrypt = "danielcgl10599@gmail.com";
            string dataEncrypt = aesClient.Encrypt(dataToEncrypt);
            Console.WriteLine(dataToEncrypt);
            Console.WriteLine(dataEncrypt);

            string dataDecrypt = aesClient.Decrypt(dataEncrypt);
            Console.WriteLine(dataEncrypt);
            Console.WriteLine(dataDecrypt);

        }
    }
}
