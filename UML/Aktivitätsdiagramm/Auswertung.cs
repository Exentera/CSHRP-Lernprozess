using System;
using System.Linq;

namespace IT072406.UML.Aktivitätsdiagramm
{
    public class Auswertung
    {
        public int[] werte;




        public void auswahlmenu()
        {
            
            string[] optionen = { "Minimum", "Mittlere Abweichung", "Maximum"};
            //int gewählteOption = Menu.ShoweMenu(optionen);
            int gewählteOption = 0;

            Console.Clear();
            Console.WriteLine($"Du hast '{optionen[gewählteOption]}' ausgewählt!");

            switch (gewählteOption)
            {
                case 0:
                    int min = werte.Min();
                    Console.WriteLine($"Minimaler Messwert {min}");
                    break;
                case 1:
                    double avrg = werte.Average();
                    Console.WriteLine($"Mittelwert Messwert {avrg}");
                    break;
                case 2:
                    int max = werte.Max();
                    Console.WriteLine($"Maximal Messwert {max}");
                    break;
            }
        }
    }
    
}