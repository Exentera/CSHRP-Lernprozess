using System;
using System.Collections.Generic;
using System.Globalization;

namespace IT072406.UML.Sequenzdiagramm
{
    public class Person
    {
        protected string vorname;
        protected string nachname;
        protected DateTime geburtsdatum;
        protected int alter;

        public void setVorname(string vorname)
        {
            this.vorname = vorname;
        }
        public void setNachname(string nachname)
        {
            this.nachname = nachname;
        }
    }

    public class Verkaufer : Person
    {
        private int verkaufer_id;
        private List<Kunde> kundenListe = new List<Kunde>();

        public void alterPuefen(Kunde kunde)
        {
            int kundenAlter = kunde.getKundenAlter();
            
            if (kundenAlter < 18)
            {
                Console.WriteLine($"'Kein Vertrag, Kunde ist zu Grün hinter den Ohren - {alter} Alt");
            }
            else
            {
                Console.WriteLine($"Der Kunde Erfüllt die Vertagsbedingungen!");
            }
        }
        
        public void kundenDatenErfragen()
        {
            bool ok = false;
            string vorname = null;
            string nachname = null;
            int kundenAlter = 0;
            string geburtsDatumString = null;
            DateTime geburtsDatum = default;

            string[] options_j_n = { "Ja", "Nein" };
            int select;

            select = Menu.ShoweMenu("Neukunde Erfassen", options_j_n);
            ok = select != 0;

            while (!ok)
            {
                Console.Clear();
                Console.WriteLine("Kundendaten Erfassen");
                Console.Write("Vorname:\t");
                vorname = Console.ReadLine();
                Console.Write("Nachname:\t");
                nachname = Console.ReadLine();

                bool dateOk = false;
                while (!dateOk)
                {
                    Console.Clear();
                    Console.WriteLine("Geburtsdatum");
                    Console.Write("Tag:\t"); string tag = Console.ReadLine();
                    Console.Write("Monat:\t"); string monat = Console.ReadLine();
                    Console.Write("Jahr:\t"); string jahr = Console.ReadLine();

                    geburtsDatumString = $"{int.Parse(tag):D2}.{int.Parse(monat):D2}.{int.Parse(jahr):D4}";

                    if (DateTime.TryParseExact(
                            geburtsDatumString,
                            "dd.MM.yyyy",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out geburtsDatum))
                    {
                        DateTime heute = DateTime.Today;
                        kundenAlter = heute.Year - geburtsDatum.Year;
                        if (geburtsDatum > heute.AddYears(-kundenAlter))
                        {
                            kundenAlter--;
                        }
                        Console.WriteLine($"Alter:\t{kundenAlter}");
                        Console.WriteLine($"Das Datum {geburtsDatumString} ist gültig.\n");
                        Console.WriteLine("Enter zum Fortfahren");
                        Console.ReadLine();
                        dateOk = true;
                    }
                    else
                    {
                        Console.WriteLine($"Das Datum {geburtsDatumString} ist ungültig.");
                        Console.WriteLine("Enter um erneut das Datum einzugeben");
                        Console.ReadLine();
                    }
                }

                select = Menu.ShoweMenu("Sind die Daten richtig?\n" +
                                        $"Vorname:\t{vorname}\n" +
                                        $"Nachname:\t{nachname}\n" +
                                        $"Alter:\t\t{kundenAlter}\n" +
                                        $"Geburtsdatum:\t{geburtsDatumString}", options_j_n);
                ok = select == 0;

                if (!ok) continue;

                int kundenID = kundenListe.Count + 1;
                kundenListe.Add(new Kunde(vorname, nachname, kundenID,geburtsDatum, kundenAlter));

                Console.WriteLine("Der neue Kunde ist:");
                Console.WriteLine($"Vorname:\t{vorname}");
                Console.WriteLine($"Nachname:\t{nachname}");
                Console.WriteLine($"Geburtsdatum:\t{geburtsDatum}");
                Console.WriteLine($"Alter:\t{kundenAlter}");
                Console.WriteLine($"Kunden ID:\t{kundenID}");

                select = Menu.ShoweMenu("Weitere Neukunden erfassen?", options_j_n);
                if (select == 1)
                {
                    break;
                }
                ok = false;
            }
        }
    }

    public class Kunde : Person
    {
        private int kundenID;

        public Kunde(string vorname, string nachname, int kundenID,DateTime geburtsDatum, int alter)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.kundenID = kundenID;
            this.geburtsdatum = geburtsDatum;
            this.alter = alter;
        }


        public int getKundenAlter()
        {
            return this.alter;
        }
        public int getKundenID() => kundenID;
        public void setKundenID(int kundenID) => this.kundenID = kundenID;
    }

    public class Sequenzdiagramm_A_5_1
    {
        public static void run()
        {
            Console.Clear();
            Verkaufer maier = new Verkaufer();
            maier.kundenDatenErfragen();
            int kundenID = Convert.ToInt32(Console.ReadLine());
            Kunde kundenListe[kundenID];                    //wie komm ich an die kundenListe von hier aus
            maier.alterPuefen(kundenListe[kundenID]);       // 
        }
    }
}
