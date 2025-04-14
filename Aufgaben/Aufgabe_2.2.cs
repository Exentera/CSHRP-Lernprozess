using System;

namespace IT072406.Aufgaben
{
    public class Aufgabe_2_2
    {
        
        static void ausgabeRaute(int anzahl)
        {
            for (int i = 0; i < anzahl; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine(); 
        }

        public static void run()
        {
            string text = "# C# ist eine moderne Programmiersprache #";
            int countedChars = text.Length;

            ausgabeRaute(countedChars);
            
            Console.WriteLine(text);
            
            ausgabeRaute(countedChars);
            
        }
    }
}