using System;
using System.Diagnostics.Eventing.Reader;

namespace IT072406.OOP
{
    public class Personen
    {
        //// ATTRIBUTE
        private string vorname;
        private int alter;

        #region --CONSTRUCTOR--

                //// CONSTRUCKTOR
                public Personen()
                {
                    Console.WriteLine("OK");
                }
                
                public Personen(string vorname, int alter)
                {
                    this.vorname = vorname;
                    this.alter = alter;
                }

        #endregion
        

        
        
        //// GETTER / SETTER wird verwendet um private Attribute zu getten &zu setzen
        
        // NAME
        public void SetVorname(string vorname)
        {
            this.vorname = vorname;
        }
        public string GetVorname()
        {
            return this.vorname;
        }
        // ALTER
        public void SetAlter(int alter)
        {
            this.alter = alter;
        }
        public int GetAlter()
        {
            return this.alter;
        }
        
        
        //// EIGENE METHODEN
        public void Ausgabe()
        {
            Console.WriteLine($"{vorname} ist {alter} Jahre alt.");
        }
        
    }
}