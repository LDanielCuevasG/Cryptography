using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    public class AESClient : CryptographyClient
    {

        private readonly Aes AESService;


        public AESClient() {
            AESService = Aes.Create();
        }

        public override void GenerateKeys(string path)
        {

            byte[] keyBytes = AESService.Key;
            FileStream publicKeyStream = new FileStream(Path.Combine(path, "AES_Key.aes"), FileMode.Create, FileAccess.Write);
            publicKeyStream.Write(keyBytes, 0, keyBytes.Length);
            publicKeyStream.Close();

            byte[] ivKey = AESService.IV;
            FileStream privateKeyStream = new FileStream(Path.Combine(path, "AES_IV.aes"), FileMode.Create, FileAccess.Write);
            privateKeyStream.Write(ivKey, 0, ivKey.Length);
            privateKeyStream.Close();

        }

        public override void LoadKeys(string path)
        {
            FileStream keyStream = new FileStream(Path.Combine(path, "AES_Key.aes"), FileMode.Open, FileAccess.Read);
            byte[] keyBytes = new byte[keyStream.Length];
            keyStream.Read(keyBytes, 0, (int)keyBytes.Length);
            AESService.Key = keyBytes;

            FileStream ivStream = new FileStream(Path.Combine(path, "AES_IV.aes"), FileMode.Open, FileAccess.Read);
            byte[] ivBytes = new byte[ivStream.Length];
            ivStream.Read(ivBytes, 0, (int)ivBytes.Length);
            AESService.IV = ivBytes;
        }

        public override string Encrypt(string data)
        {
            string result = String.Empty;

            ICryptoTransform encryptor = AESService.CreateEncryptor(AESService.Key, AESService.IV);
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)) 
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt)) 
                    {
                        swEncrypt.Write(data);
                    }
                    byte[] resultBytes = msEncrypt.ToArray();
                    result = Convert.ToBase64String(resultBytes);
                }
            }

            return result;
        }

        public override string Decrypt(string data)
        {
            string result = String.Empty;

            ICryptoTransform decryptor = AESService.CreateDecryptor(AESService.Key, AESService.IV);
            byte[] dataBytes = Convert.FromBase64String(data);
            using (MemoryStream msDecrypt = new MemoryStream(dataBytes))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        result = srDecrypt.ReadToEnd();
                    }
                }
            }

            return result;
        }

    }
}
