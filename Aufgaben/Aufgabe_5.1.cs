using System;

namespace IT072406.Aufgaben
{
    public class Aufgabe_5_1
    {
        public static void run()
        {
            int max = 0;
            
            Console.WriteLine("Wert 1 eingebn:");
            int a = Convert.ToInt32( Console.ReadLine()) ;
            Console.WriteLine("Wert 2 eingebn:");
            int b = Convert.ToInt32( Console.ReadLine()) ;
            Console.WriteLine("Wert 3 eingebn:");
            int c = Convert.ToInt32( Console.ReadLine()) ;

            if (a > b && a > c)
            {
                max = a;
                Console.WriteLine($"{a} ist groeßer als {b} und {c}");
            }

            if (b > a && b > c)
            {
                max = b;
                Console.WriteLine($"{b} ist groeßer als {a} und {c}");
            }

            if (c > a && c > a)
            {
                Console.WriteLine($"{b} ist groeßer als {a} und {c}");
            }

        }
    }
}