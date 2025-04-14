using System;

namespace IT072406.UML
{
    public class Anzeige
    {

        public void Laenge(Linie linie)
        {
            Punkt a = linie.GetPunkt_a();
            Punkt b = linie.GetPunkt_b();
            
            double result = Math.Sqrt(Math.Pow(b.GetX() - a.GetX(),2) + Math.Pow(b.GetY() - a.GetY(),2));
            Console.WriteLine("Linie hat die Länge: " + result);
        }

        public void Flaeche(Kreis kreis)
        {
            double result = Math.Pow(kreis.GetKreis_radius(),2) * Math.PI;
            Console.WriteLine("Kreis hat die Fläche von: " + result);
        }

        public void Flaeche(Rechteck rechteck)
        {
            Punkt a = rechteck.GetPunkt_a();
            Punkt b = rechteck.GetPunkt_b();
            Punkt c = rechteck.GetPunkt_c();

            double laenge_AB = rechteck.GetPunkt_b().GetX() - rechteck.GetPunkt_a().GetX();
            double laenge_BC = rechteck.GetPunkt_b().GetY() - rechteck.GetPunkt_c().GetY();
            double result = laenge_AB * laenge_BC;
            Console.WriteLine("Rechteck hat die Fläche von: " + result);
        }
    }
}