using System;
using System.IO;
using System.Net;

namespace AccessingNetworShare
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const string path = @"\\30.0.0.105\dm$"; //@"\\Srv-1c-for\dm$"; // @"\\30.0.0.105\dm$";
                const string login = @"DT\su_vst_obmen";
                const string password = "VO@#fn2f82jfhdn2jhfd1";
                var text = $"{DateTime.Now:O}    C# Corner is a community of software and data developers";

                using (new NetworkConnection(path, new NetworkCredential(login, password))) 
                    File.WriteAllText(path + @"\csc.txt", text);

            }
            catch (Exception exc)
            {
                Console.WriteLine($"Exception {exc}");
            }
            Console.WriteLine("End...");
            Console.ReadKey();
        }
    }
}
