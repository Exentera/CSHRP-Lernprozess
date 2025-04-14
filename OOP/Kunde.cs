using System;

namespace IT072406.OOP
{
    // AUFGABE
    // Kunden Klasse mit
    // Vorname, Nachname, Straße, Hausnummer, PLZ, Ort
    // die Klasse Kunde soll mit der Methode DetailsAusgaben
    // Erstelle 3 Testkunden und gebe alle Daten aus 
    
    public class Kunde
    {
        public string vorname;
        public string nachname;
        public string straße;
        public int hausnummer;
        public int plz;
        public string ort;

        public void printKundenInfo()
        {
            Console.WriteLine("Vorname:   \t" + vorname);
            Console.WriteLine("Nachname:  \t" + nachname);
            Console.WriteLine("Straße:    \t" + straße);
            Console.WriteLine("Hausnummer:\t" + hausnummer);
            Console.WriteLine("PLZ:       \t" + plz);
            Console.WriteLine("Ort:       \t" + ort);
            Console.WriteLine();
        }
    }
}