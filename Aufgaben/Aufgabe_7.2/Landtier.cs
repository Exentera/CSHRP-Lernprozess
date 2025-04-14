using System;

namespace IT072406.Aufgaben.Aufgabe_7._2
{
    public class Landtier : Tier ,IGeschwindigkeit
    {
        
        public Landtier(string name, int geschwindigkeit)
        {
            this.name = name;
            this.GESCHWINDIGKEIT = geschwindigkeit;
        } 
        
        public int GESCHWINDIGKEIT { get; set; }
        
        public override void Steckbrief()
        {
            Console.Write("Geschwindigkeit: ");
        }
    }
}