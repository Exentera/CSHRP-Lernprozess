using System;

namespace IT072406.Aufgaben
{
    public class Aufgabe_4_2
    {
        public static void run()
        {
            

            int erg = 0;
            
            Console.WriteLine("Zahl 1 eingebn:");
            int a = Convert.ToInt32( Console.ReadLine()) ;
            Console.WriteLine("Zahl 2 eingebn:");
            int b = Convert.ToInt32( Console.ReadLine()) ;
            
            while (a >= b) 
            {
                a -= b;
                erg++;
            }
            int rest = a; 

            Console.WriteLine($"Quotient: {erg}, Rest: {rest}"); 
        }
    }
}