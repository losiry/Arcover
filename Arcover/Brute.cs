using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms; 
using System.Diagnostics;
using System.Threading;

namespace Arcover
{
    public static class Brute
    {
        public static event EventHandler<LoggerEventArgs> GetOutput;

        public static string ExtractPath { get; set; }
        
        public static bool Founded { get; set; }
        public static string ArchivePath { get; set; }

        static Brute()
        {
            ExtractPath = Path.GetTempPath() + "/Arcover";
            Founded = false;

            // Create directory in User's Temp directory to extract files or clear the content of exisiting one.
            if (Directory.Exists(ExtractPath)) Directory.Delete(ExtractPath, true);
            Directory.CreateDirectory(ExtractPath);
        }

        public static void OnGetOutput(LoggerEventArgs e) 
        {
            EventHandler<LoggerEventArgs> handler = GetOutput;
           
            if (handler != null) handler(null, e);
        }
    }

    public static class DictionaryBrute
    {
        private static StreamReader dictReader;

        // Multithreading dictionary bruteforce function
        public static void Run(string dictionaryPath, int threadNum)
        {
            if (dictionaryPath == String.Empty) throw new Exception("WARNING: The dictionary path can't be empty");
            dictReader = new StreamReader(dictionaryPath);


            for (int i = 0; i < threadNum; i++)
            {
                Thread x = new Thread(checkPassword);
                x.Start();
            }
            // Refresh ProgressBar every 5 secondes here
        }

        public static void checkPassword()
        {
            string password = String.Empty;
            bool eof = false;

            Process sevenZip = new Process();
            string fileName = Path.GetFullPath("7za.exe");

            sevenZip.StartInfo.FileName = fileName;
            sevenZip.StartInfo.UseShellExecute = false;
            sevenZip.StartInfo.CreateNoWindow = true;

            do
            {
                lock (DictionaryBrute.dictReader)
                {
                    password = DictionaryBrute.dictReader.ReadLine();

                    if (password != null)
                    {
                        password = password.Trim('\n').Trim();
                    }
                    else
                    {
                        eof = true;
                        break;
                    }
                    //eof = DictionaryBrute.dictReader.EndOfStream;   
                }
                sevenZip.StartInfo.Arguments = String.Format("e \"{0}\" -o\"{1}\" -p{2} -aoa", Brute.ArchivePath, Brute.ExtractPath, password);
                sevenZip.Start();
                sevenZip.WaitForExit();

                // Some crap is hiding here. Need to be rewriten with 7z.dll.  
                if (sevenZip.ExitCode != 0) Brute.OnGetOutput(new LoggerEventArgs(String.Format("TRIED PASS \"{0}\" is incorrect. 7zip Exit Code: {1}", password, sevenZip.ExitCode)));
                else
                {
                    Brute.OnGetOutput(new LoggerEventArgs(String.Format("PASSWORD FOUNDED: \"{0}\" is correct. 7zip Exit Code: {1}", password, sevenZip.ExitCode)));
                    Brute.Founded = true;
                    return;
                }
            } while (eof != true || Brute.Founded == false);
            // Закрытие потока
        }
    }

    public class ForceBrute
    {
        private static Dictionary<string, string> sets = new Dictionary<string, string>();

        private static string alphabet;

        // Returns keys from "sets" dictionary to create checkedListBox 
        public static string[] Sets
        {
            get
            {
                string[] keys = new string[sets.Keys.Count];
                int i = 0;

                foreach (var el in sets.Keys)
                {
                    keys[i] = el;
                    i++;
                }

                return keys;
            }
        }

        static ForceBrute()
        {
            // Dictionary Initialization
            sets.Add("Numeric [0-9]", "0123456789");
            sets.Add("Lowercase letters [a-z]", "abcdefghijklmnopqrstuvwxyz");
            sets.Add("Uppercase letters [A-Z]", "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        }

        public static void Run()
        {
            StringBuilder password = new StringBuilder(8, 16);
        }

        // For Debugging Purposes
        public static string GetAlphabet()
        {
            return alphabet;
        }

        // Setting alphabet from checked boxes on form.
        public static void SetAlphabet(CheckedListBox.CheckedItemCollection checkedItems)
        {
            alphabet = String.Empty;

            foreach (var item in checkedItems)
            {
                alphabet += sets[item.ToString()];
            }
        }
    }

    public class LoggerEventArgs : EventArgs
    {
        private string message;
        
        public LoggerEventArgs(string s)
        {
            message = s;
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        } 
    }
}
