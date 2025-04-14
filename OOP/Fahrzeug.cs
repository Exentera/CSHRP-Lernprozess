using System;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;

namespace IT072406.OOP
{
    public class Fahrzeug
    {
      #region --ATTRIBUTE--
      
        private string hersteller;
        private string modell;
        private string farbe;
        private float preis;
        
      #endregion

      #region --CONSTRUCKTOR--

        public Fahrzeug(){}
        public Fahrzeug(string hersteller)
        {
            this.hersteller = hersteller;
        }
        public Fahrzeug(string hersteller, string modell)
        {
            this.hersteller = hersteller;
            this.modell = modell;
        }
        public Fahrzeug(string hersteller, string modell, string farbe)
        {
            this.hersteller = hersteller;
            this.modell = modell;
            this.farbe = farbe;
        }
        public Fahrzeug(string hersteller, string modell, string farbe, float preis)
        {
            this.hersteller = hersteller;
            this.modell = modell;
            this.farbe = farbe;
            this.preis = preis;
        }
        
      #endregion
        
      #region --GETTER/SETTER--

        // Hersteller
        public void SetHersteller(string hersteller)
        {
            this.hersteller = hersteller;
        }
        public string GetHersteller()
        {
            return this.hersteller;
        }
        
        // Modell
        public void SetModell(string modell)
        {
            this.modell = modell;
        }
        public string GetModell()
        {
            return this.modell;
        }
        
        // Farbe
        public void SetFarbe(string farbe)
        {
            this.farbe = farbe;
        }
        public string GetFarbe()
        {
            return this.farbe;
        }
        
        // Preis
        public void SetPreis(float preis)
        {
            this.preis = preis;
        }
        public float GetPreis()
        {
            return this.preis;
        }

      #endregion


      #region --METHODEN--
        public void Ausgabe()
        {
            Console.WriteLine($"Hersteller: {hersteller}\nModell: {modell}\nFarbe: {farbe}\nPreis: {preis} $");
        }
      #endregion
        
        
        
        
        
        
    } //end class


    

}