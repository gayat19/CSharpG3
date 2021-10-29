using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnderstndingSecurityApplication
{

    class Program
    {
        void SimpleWithSalt()
        {
            //var password = "password";
            //var salt = "123";
            //var encrypted = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
            //var algo = new AesManaged();
            //var rfcKey = encrypted.GetBytes(algo.KeySize / 8);
            //var rfcBlock = encrypted.GetBytes(algo.BlockSize / 8);
            //var bufferStream = new MemoryStream();
            //var algorithm = algo.CreateEncryptor(rfcKey, rfcBlock);
            //var cStream = new CryptoStream(bufferStream, algorithm, CryptoStreamMode.Write);

            var password = "password";
            var hmac = new HMACSHA512();
            var key = hmac.Key;
            var encrpPassword = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            //for (int i = 0; i < encrpPassword.Length; i++)
            //{
            //    Console.Write(encrpPassword[i]);
            //}
            Console.WriteLine("Enter the password");
            string userPass = Console.ReadLine();
            var userEncrpPass = new HMACSHA512(key).ComputeHash(Encoding.UTF8.GetBytes(userPass));
            for (int i = 0; i < encrpPassword.Length; i++)
            {
                if(encrpPassword[i] != userEncrpPass[i])
                {
                    Console.WriteLine("Incorrect Password");
                    return;
                }
            }
            Console.WriteLine("Login success");
        }

        void AsymmerticSample()
        {
            //var rsaProvider = new RSACryptoServiceProvider();
            var rawBytes = Encoding.Default.GetBytes("hello world..");
            var decryptedText = string.Empty;
            var keys = default(byte[]);
            using (var rsaProvider = new RSACryptoServiceProvider())
            {
                var useOaepPadding = true;
                keys = rsaProvider.ExportCspBlob(true);
                var encryptedBytes =
                   rsaProvider.Encrypt(rawBytes, useOaepPadding);

                rsaProvider.ImportCspBlob(keys);
                var decryptedBytes =
                   rsaProvider.Decrypt(encryptedBytes, useOaepPadding);

                decryptedText = Encoding.Default.GetString(decryptedBytes);
                Console.WriteLine(decryptedText);
            }
            // decryptedText == hello world..

        }
        void ReadCert()
        {
            var store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            var certificate = default(X509Certificate);
            var certificateName = "CN=FourthCoffee";
            store.Open(OpenFlags.ReadOnly);
            foreach (var item in store.Certificates)
            {
                if(item.SubjectName.Name == certificateName)
                {
                    certificate = item;
                    break;
                }
            }
            if(certificate!=null)
            {
                Console.WriteLine("Valid User");
            }
        }
        static void Main(string[] args)
        {
            new Program().ReadCert();
            Console.ReadKey();
        }
    }
}
