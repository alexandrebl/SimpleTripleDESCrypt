using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTripleDESCrypt.Intefaces {

    /// <summary>
    /// Simple crypto library
    /// </summary>
    public interface ISimpleCrypt {

        /// <summary>
        /// Encrypt data
        /// </summary>
        /// <param name="data">data to encrypt</param>
        /// <returns>result of encrytation</returns>
        byte[] TripleDesEncrypt(byte[] data);

        /// <summary>
        /// Decrypt data
        /// </summary>
        /// <param name="data">data to decrypt</param>
        /// <returns>result of decryptation</returns>
        byte[] TripleDesDecrypt(byte[] data);
    }
}
