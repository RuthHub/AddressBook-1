using System;
using System.Configuration;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {

         // I LOVE THIS STUFF SO MUCH
         string name = ConfigurationManager.AppSettings["ApplicationName"];
         Console.WriteLine("WECOME TO:");
         Console.WriteLine(name);
         Console.WriteLine(new string('-',Console.WindowWidth - 4));
         Console.WriteLine();
         Console.WriteLine("Press Enter to continue.");
         Console.ReadLine();

         Rolodex rolodex = new Rolodex();
         rolodex.DoStuff();

        }
    }
}
