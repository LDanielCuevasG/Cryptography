using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    public class RSAClient
    {

        private readonly RSACryptoServiceProvider RSAService;

        private static string Key;


        public RSAClient() {
            RSAService = new RSACryptoServiceProvider();
        }

        public void GenerateKeys(string path)
        {

            string publicKey = RSAService.ToXmlString(false);
            byte[] publicKeyBytes = Encoding.ASCII.GetBytes(publicKey);
            FileStream publicKeyStream = new FileStream(Path.Combine(path, "PublicKey.rsa"), FileMode.Create, FileAccess.Write);
            publicKeyStream.Write(publicKeyBytes, 0, publicKeyBytes.Length);
            publicKeyStream.Close();

            string privateKey = RSAService.ToXmlString(true);
            byte[] privateKeyBytes = Encoding.ASCII.GetBytes(privateKey);
            FileStream privateKeyStream = new FileStream(Path.Combine(path, "PrivateKey.rsa"), FileMode.Create, FileAccess.Write);
            privateKeyStream.Write(privateKeyBytes, 0, privateKeyBytes.Length);
            privateKeyStream.Close();

        }

        public void LoadKeys(string path, string filename)
        {
            FileStream privateKeyStream = new FileStream(Path.Combine(path, filename), FileMode.Open, FileAccess.Read);
            byte[] privateKeyBytes = new byte[privateKeyStream.Length];
            privateKeyStream.Read(privateKeyBytes, 0, (int)privateKeyStream.Length);
            Key = Encoding.UTF8.GetString(privateKeyBytes);

            RSAService.FromXmlString(Key);
        }

        public string Encrypt(string data)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            byte[] resultBytes = RSAService.Encrypt(dataBytes, false);
            string result = Convert.ToBase64String(resultBytes);

            return result;
        }

        public string Decrypt(string data)
        {
            byte[] dataBytes = Convert.FromBase64String(data);
            byte[] resultBytes = RSAService.Decrypt(dataBytes, false);
            string result = Encoding.UTF8.GetString(resultBytes);

            return result;
        }


    }
}
