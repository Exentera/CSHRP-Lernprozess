using System;

namespace IT072406.Aufgaben
{
    public class Aufgabe_3_1
    {
        public static void run()
        {
            int jahre = 3;
            
            float startkapital = 1000.00f;
            float zinssatz = 0.05f;
            float endbetrag = startkapital;

            for (int i = 0; i < jahre; i++)
            {
                endbetrag *= (1 + zinssatz);
            }
            Console.WriteLine(endbetrag);
        }
    }
}