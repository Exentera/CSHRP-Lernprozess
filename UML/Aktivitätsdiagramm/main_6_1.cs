using System;
using System.Security.Cryptography.X509Certificates;

namespace IT072406.UML.Aktivitätsdiagramm
{
    public class main_6_1
    {
        public static void Run()
        {
            Auswertung auswertung = new Auswertung();
            
            Console.Write("Anzahl der Messwerte eingeben: ");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            auswertung.werte = new int[anzahl];

            for (int i = 0; i < anzahl; i++)
            {   
                Console.Write($"Messwert {i+1} :");
                auswertung.werte[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Clear();
            
            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine($"Messwert {i+1}\t|\t{auswertung.werte[i]}");
            }
            
            auswertung.auswahlmenu();

        }
    }
}