using SimpleTripleDESCrypt.Intefaces;
using System.Security.Cryptography;

namespace SimpleTripleDESCrypt.Library {

    /// <summary>
    /// Simple crypto library
    /// </summary>
    public class SimpleCrypt : ISimpleCrypt {

        /// <summary>
        /// TripleDES library
        /// </summary>
        private readonly TripleDES _tripleDes;

        /// <summary>
        /// Contructor method
        /// </summary>
        /// <param name="desKey">3 DES Key </param>
        /// <param name="desIv">Component</param>
        /// <param name="paddingMode">Padding mode</param>
        /// <param name="cipherMode">cipher mode</param>
        public SimpleCrypt(byte[] desKey, byte[] desIv, PaddingMode paddingMode = PaddingMode.None, CipherMode cipherMode = CipherMode.CBC) {
            //Initialize library
            _tripleDes = new TripleDESCryptoServiceProvider {
                Key = desKey,
                IV = desIv,
                Padding = paddingMode,
                Mode = cipherMode
            };
        }

        /// <summary>
        /// Encrypt data
        /// </summary>
        /// <param name="data">data to encrypt</param>
        /// <returns>result of encrytation</returns>
        public byte[] TripleDesEncrypt(byte[] data) {
            //Create crypto library
            var ct = _tripleDes.CreateEncryptor();
            //Output data
            var output = ct.TransformFinalBlock(data, 0, data.Length);
            //Result
            return output;
        }

        /// <summary>
        /// Decrypt data
        /// </summary>
        /// <param name="data">data to decrypt</param>
        /// <returns>result of decryptation</returns>
        public byte[] TripleDesDecrypt(byte[] data) {
            //Create decrypto library
            var ct = _tripleDes.CreateDecryptor();
            //Output data
            var output = ct.TransformFinalBlock(data, 0, data.Length);
            //Result
            return output;
        }
    }
}