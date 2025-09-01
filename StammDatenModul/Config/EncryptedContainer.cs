using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StammDatenModul.Config
{
    public class EncryptedContainer
    {
        public string ivJson { get; set; }
        public string ciphertextJson { get; set; }
        public string ivSig { get; set; }
        public string encryptedSignature { get; set; }
    }
}
