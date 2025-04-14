using System;

namespace IT072406.Grundlagen
{
    public class Eingabe
    {
        public static void run()
        {
            string eingabe;
            Console.WriteLine("Bitte geben Sie Ihren Namen ein:");

            eingabe = Console.ReadLine();
            
            Console.WriteLine("Ihre Eingabe war" + eingabe);
        }
    }
}