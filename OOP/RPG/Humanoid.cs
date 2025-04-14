using System;

namespace IT072406.OOP.RPG
{
    public class Humanoid
    {
        public string name;
        
        public int lebenspunkte = 100;
        
        public int angriffsSchaden = 10;
        public int level = 1;
        
        
        public Humanoid()
        {
        }
        
        public Humanoid(string name , int lebenspunkte, int angriffsSchaden, int level)
        {
            this.name = name;
            this.lebenspunkte = lebenspunkte;
            this.angriffsSchaden = angriffsSchaden;
            this.level = level;
        }

        public virtual void Angriff(Humanoid ziel)
        {
            Console.WriteLine(name + "greift " + ziel.name + " an!");
            ziel.Schaden(angriffsSchaden);
            Console.WriteLine($"{name} mach {angriffsSchaden} Schaden bei {ziel.name}!");
        }

        public virtual void Schaden(int wert)
        {
            lebenspunkte -= wert;
            if (lebenspunkte <= 0)
            {
                Console.WriteLine("ARGGGGGGG");
            }
        }

        public virtual void Status(Humanoid ziel)
        {
            Console.WriteLine($"{name} hat {lebenspunkte}");
            Console.WriteLine($"{ziel.name} hat {ziel.lebenspunkte}");
        }
    }
}