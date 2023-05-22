using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPChangeNotifikace
{
    internal class CredentialsSaver
    {
        private char[] Alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private char[] Key =      "qazwsxedcrfvtgbyhnujmikolp".ToCharArray();
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string CurrentIP { get; set; }
        public CredentialsSaver()
        {
            Email = "";
            Password = "";
            PhoneNumber = "";
            CurrentIP = "";
        }
        public bool AllCredentials => (Email != "" && Password != "" && PhoneNumber != "" && CurrentIP != "");
        public void Save()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"log.txt"))
                {
                    sw.WriteLine(Encrypt(Email) + ";" + Encrypt(Password) + ";" + Encrypt(PhoneNumber) + ";" + Encrypt(CurrentIP));
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Něco se pokazilo při ukládání údajů!");
            }
        }
        public void Load()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"log.txt"))
                {
                    string row = sr.ReadLine();
                    string[] stats = row.Split(';');
                    Email = Decrypt(stats[0]);
                    Password = Decrypt(stats[1]);
                    PhoneNumber = Decrypt(stats[2]);
                    CurrentIP = Decrypt(stats[3]);
                }
            }
            catch (Exception)
            {
            }
        }
        public void DeleteSavedFiles()
        {
            File.Delete(@"log.txt");
        }
        public string Encrypt(string text)
        {
            string encryptetText = "";
            foreach (var item in text)
            {
                if (char.IsLetter(item))
                {
                    int index = Array.IndexOf(Alphabet, item);
                    encryptetText += Key[index];
                }
                else
                    encryptetText+= item;
            }
            return encryptetText;
        }
        public string Decrypt(string text)
        {
            string decryptedText = "";
            foreach (var item in text)
            {
                if (char.IsLetter(item))
                {
                    int index = Array.IndexOf(Key, item);
                    decryptedText += Alphabet[index];
                }
                else
                    decryptedText += item;
            }
            return decryptedText;
        }
    }
}
