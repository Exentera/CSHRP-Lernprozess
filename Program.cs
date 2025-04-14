using System;
using System.CodeDom;
using System.Runtime.Remoting.Metadata;
using System.Text;
using IT072406.Aufgaben;
using IT072406.Grundlagen;
using IT072406.OOP;
using IT072406.UML;
using Punkt = IT072406.UML.Punkt;
using Zahl = IT072406.OOP.Zahl;

namespace IT072406
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
          #region --Personen--

            // Ohne Construcktor
            //Personen susiSorglos = new Personen();
            //susiSorglos.SetVorname("Susi");
            //susiSorglos.SetAlter(55);
            
            // Mit Construcktor
            /*
            Personen susiSorglos = new Personen("Susi",55);
            Personen conan = new Personen("Conan",98);
            Personen tyson = new Personen("Tyson",63);
            Personen timTunichtGut = new Personen("Tim",33);

            int[] zahlen = new int[2];
            Personen[] personenListe = new Personen[4];

            personenListe[0] = susiSorglos;
            personenListe[1] = new Personen("Dieter",66);
            personenListe[2] = tyson;
            personenListe[3] = timTunichtGut;
            
            foreach (Personen p in personenListe)
            {
                p.Ausgabe();
            }
            //Console.WriteLine("Vorname: " + susiSorglos.GetVorname());
            //Console.WriteLine("Alter: " + susiSorglos.GetAlter());
            */
          #endregion
          #region --Fahrzeug--
            /*
            Fahrzeug[] autoListe = new Fahrzeug[4];
            
            autoListe[0] = new Fahrzeug("Ford", "Falcon XB GT Coupe (1973)", "Schwarz mit Flammen-Sidepipes", 250000);
            autoListe[1] = new Fahrzeug("Mack", "R-Series (angepasst)", "Rostig / Sandfarben", 300000);
            autoListe[2] = new Fahrzeug("Chevrolet", "1934 Chevy 5-Window Coupe", "Silber / Rostig", 100000);
            autoListe[3] = new Fahrzeug("Cadillac", "Zwei 1959 Cadillac Coupe de Ville", "Rostig, Sandfarben", 500000);
            
            foreach (Fahrzeug auto in autoListe)
            {
                auto.Ausgabe();
                Console.WriteLine();
            }
            */
          #endregion
          #region --ZahlenInWorte--

            int zahl = Convert.ToInt32(Console.ReadLine());

            Zahl a = new Zahl(zahl);
            
            a.Spell();

            #endregion

            



        }
    }
}