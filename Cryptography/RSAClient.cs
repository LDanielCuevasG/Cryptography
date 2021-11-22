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
    public class RSAClient : CryptographyClient
    {

        private readonly RSACryptoServiceProvider RSAService;

        private static string Key;


        public RSAClient() {
            RSAService = new RSACryptoServiceProvider();
        }

        public override void GenerateKeys(string path)
        {

            string publicKey = RSAService.ToXmlString(false);
            byte[] publicKeyBytes = Encoding.ASCII.GetBytes(publicKey);
            FileStream publicKeyStream = new FileStream(Path.Combine(path, "RSA_PublicKey.rsa"), FileMode.Create, FileAccess.Write);
            publicKeyStream.Write(publicKeyBytes, 0, publicKeyBytes.Length);
            publicKeyStream.Close();

            string privateKey = RSAService.ToXmlString(true);
            byte[] privateKeyBytes = Encoding.ASCII.GetBytes(privateKey);
            FileStream privateKeyStream = new FileStream(Path.Combine(path, "RSA_PrivateKey.rsa"), FileMode.Create, FileAccess.Write);
            privateKeyStream.Write(privateKeyBytes, 0, privateKeyBytes.Length);
            privateKeyStream.Close();

        }

        public override void LoadKeys(string path)
        {
            FileStream privateKeyStream = new FileStream(Path.Combine(path, "RSA_PrivateKey.rsa"), FileMode.Open, FileAccess.Read);
            byte[] privateKeyBytes = new byte[privateKeyStream.Length];
            privateKeyStream.Read(privateKeyBytes, 0, (int)privateKeyStream.Length);
            Key = Encoding.UTF8.GetString(privateKeyBytes);

            RSAService.FromXmlString(Key);
        }

        public override string Encrypt(string data)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            byte[] resultBytes = RSAService.Encrypt(dataBytes, false);
            string result = Convert.ToBase64String(resultBytes);

            return result;
        }

        public override string Decrypt(string data)
        {
            byte[] dataBytes = Convert.FromBase64String(data);
            byte[] resultBytes = RSAService.Decrypt(dataBytes, false);
            string result = Encoding.UTF8.GetString(resultBytes);

            return result;
        }

    }
}
