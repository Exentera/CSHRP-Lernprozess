using System;

namespace IT072406.Aufgaben.Aufgabe_7._2
{
    public class Elefant : Landtier
    {
        public Elefant(string name, int geschwindigkeit) : base(name, geschwindigkeit)
        {
        }
        
        public override void Steckbrief()
        {
            Console.WriteLine($"Elefant {name}");
            base.Steckbrief();
            Console.WriteLine(GESCHWINDIGKEIT);
            Console.WriteLine();
        }
    }
}