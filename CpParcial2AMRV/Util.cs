using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CpParcial2AMRV
{
    internal class Util
    {
        private const string EncryptionKey = "SIS457-1nf0!";

        public static string Encrypt(string clearText)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(
                    EncryptionKey,
                    new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV  = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        /// <summary>Validar sólo números enteros en el evento KeyPress</summary>
        public static void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))        e.Handled = false;
            else if (Char.IsControl(e.KeyChar)) e.Handled = false;
            else                                e.Handled = true;
        }

        /// <summary>Validar sólo letras en el evento KeyPress</summary>
        public static void onlyLetters(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))        e.Handled = false;
            else if (Char.IsControl(e.KeyChar))  e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar)) e.Handled = false;
            else                                  e.Handled = true;
        }
    }
}
