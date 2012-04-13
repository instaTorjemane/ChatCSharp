using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Importation du package de sécurité implémentant la solution RSA
using System.Security.Cryptography;

namespace ChatCSharp.BLL
{
    public class RSA
    {
        public String publickey;
        public String privatekey;
        private RSACryptoServiceProvider rsa;


        public RSA(int keyLength)
        {
            AssignParameter(keyLength);
            AssignNewKey();
        }


        private void AssignParameter(int keyLength)
        {
            CspParameters cspParams;
            cspParams = new CspParameters(1, "SpiderContainer");
            cspParams.Flags = CspProviderFlags.CreateEphemeralKey;
            cspParams.ProviderName = "Microsoft Strong Cryptographic Provider";
            rsa = new RSACryptoServiceProvider(keyLength, cspParams);
        }


        private void AssignNewKey()
        {
            privatekey = rsa.ToXmlString(true);
            publickey = rsa.ToXmlString(false);
        }


        public string Encrypt(string str)
        {
            rsa.FromXmlString(publickey);

            byte[] plainbytes = System.Text.Encoding.UTF8.GetBytes(str);
            byte[] cipherbytes = rsa.Encrypt(plainbytes, false);
            return Convert.ToBase64String(cipherbytes);
        }


        public string Decrypt(string str)
        {
            rsa.FromXmlString(privatekey);

            byte[] getpassword = Convert.FromBase64String(str);
            byte[] plain = rsa.Decrypt(getpassword, false);
            return System.Text.Encoding.UTF8.GetString(plain);
        }
    }
}
