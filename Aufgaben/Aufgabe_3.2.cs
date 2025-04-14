using System;

namespace IT072406.Aufgaben
{
    public class Aufgabe_3_2
    {
        public static void run()
        {
            char first = (char)(65);
            char second = (char)(66);
            
            string result = $"{first}{second}{second}{first}";
        
            Console.WriteLine(result);
        }
    }
}