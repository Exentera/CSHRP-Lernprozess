using System;

namespace IT072406.OOP.RPG
{
    public class Jaeger : Humanoid
    {
        public Jaeger(string name ,int lebenspunkte, int angriffsSchaden, int level) : base( name ,lebenspunkte, angriffsSchaden, level)
        {
        }

        public override void Angriff(Humanoid ziel)
        {
            Console.WriteLine(name + " greift " + ziel.name + " an!");
            ziel.Schaden(angriffsSchaden);
            Console.WriteLine($"{name} macht {angriffsSchaden} Schaden bei {ziel.name}!");
        }

        public override void Schaden(int wert)
        {
            wert = angriffsSchaden;
            lebenspunkte -= wert;
            if (lebenspunkte <= 0)
            {
                Console.WriteLine("ARGGGGGGG");
            }
        }
        
        public override void Status(Humanoid ziel)
        {
            Console.WriteLine($"{name} hat {lebenspunkte}");
            Console.WriteLine($"{ziel.name} hat {ziel.lebenspunkte}");
        }
    }
}