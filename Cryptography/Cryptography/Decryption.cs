using System;
using Crypto;

namespace Cryptography
{
    static class Decryption
    {
        public static uint Decalcb(char original, char encrypted)
        {
            uint res = 0;
            if (original < encrypted)
            {
                res = 26 - (uint)(encrypted - original);
            }
            else
            {
                res = (uint)(encrypted - original);
            }
            return res;//re test
        }

        public static char Decrypted(char encryp, uint n)
        {
            char res = Convert.ToChar((encryp - 'a' + n)%26 + 'a');
            return res;
        }
    }
}
