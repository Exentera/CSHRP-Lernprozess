using System;

namespace IT072406.Aufgaben
{
    public class Aufgabe_4_1
    {
        public static void run()
        {
            int a = 10;
            int b = 20;
            int x;

            x = 3 * (a + b) - b / 8;
            Console.WriteLine(x);

            x = (a++) + (++b);
            Console.WriteLine(x);

            x = (a % b) % (b % (++a));
            Console.WriteLine(x);
        }
    }
}