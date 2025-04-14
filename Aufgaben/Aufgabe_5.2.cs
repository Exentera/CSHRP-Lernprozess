using System;

namespace IT072406.Aufgaben
{
    public class Aufgabe_5_2
    {
        public static void run()
        {
            // Eingabe der Werte
            Console.WriteLine("Bitte das Jahr eingeben:");
            int jahr = int.Parse(Console.ReadLine());
        
            Console.WriteLine("Bitte den Monat eingeben:");
            int monat = int.Parse(Console.ReadLine());
        
            Console.WriteLine("Bitte den Tag eingeben:");
            int tag = int.Parse(Console.ReadLine());
            
            bool istKorrekt = IstDatumKorrekt(jahr, monat, tag);
            
            Console.WriteLine(istKorrekt ? "Dieses Datum ist korrekt" : "Dieses Datum ist ungültig");
        }

        static bool IstDatumKorrekt(int jahr, int monat, int tag)
        {
            if (monat < 1 || monat > 12)
                return false;
            
            int maxTage;
            switch (monat)
            {
                case 4: case 6: case 9: case 11:
                    maxTage = 30;
                    break;
                case 2:
                    maxTage = IstSchaltjahr(jahr) ? 29 : 28;
                    break;
                default:
                    maxTage = 31;
                    break;
            }
            
            return (tag >= 1 && tag <= maxTage);
        }

        static bool IstSchaltjahr(int jahr)
        {
            if (jahr % 4 != 0) return false;
            if (jahr % 100 != 0) return true;
            return (jahr % 400 == 0);
        }
    }
}