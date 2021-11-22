using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    public abstract class CryptographyClient
    {
        public abstract void GenerateKeys(string path);
        public abstract void LoadKeys(string path);
        public abstract string Encrypt(string data);
        public abstract string Decrypt(string data);
    }
}
