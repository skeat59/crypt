using System.Windows.Forms;
using Crypto;

namespace Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            Crypto.Function.DecryptRot = Decryption.Decalcb ;
            Crypto.Function.DecryptionFunc = Decryption.Decrypted;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Decrypt());
        }
    }
}
