using System;

namespace IT072406.UML.Sequenzdiagramm
{
    public class Drucker
    {
        private bool eingeschaltet = true;

        public bool Drucken()
        {
            int warscheinlichkeit = 0;
            Random random = new Random();
            
            Console.WriteLine("Drucken...");
            warscheinlichkeit = random.Next(1, 1000);

            if (warscheinlichkeit > 200)
                return true;
            return false;
        }

        public void Auschalten()
        {
            eingeschaltet = false;
        }
    }
    
    public class Sachbearbeiter
    {
        private Drucker drucker;

        public void SetDrucker(Drucker drucker)
        {
            this.drucker = drucker;
        }

        public void starteDruck()
        {
            bool ok = false;
            int anzahl = 1;

            while (ok == false)
            {
                Console.WriteLine("Druckvorgang: " + anzahl++);

                ok = drucker.Drucken();

                if (!ok)
                {
                    Console.WriteLine("Fehlerhafter Druck");
                }
            }
            Console.WriteLine("Druck beendet!");
        }

        public void DruckerAuschalten(){
            drucker.Auschalten();
        }

    }
    
    public class Sequenz
    {
        public static void run()
        {
            Drucker laserStar1 =new Drucker();
            Sachbearbeiter meier  = new Sachbearbeiter();

            meier.SetDrucker(laserStar1);
            meier.starteDruck();
            meier.DruckerAuschalten();
            
        }
    }
    
}