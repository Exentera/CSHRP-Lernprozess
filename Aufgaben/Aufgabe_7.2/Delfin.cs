using System;

namespace IT072406.Aufgaben.Aufgabe_7._2
{
    public class Delfin : Wassertier
    {
        public Delfin(string name, int tauchzeit) : base(name, tauchzeit)
        {
        }
        
        public override void Steckbrief()
        {
            Console.WriteLine($"Delfin {name}");
            base.Steckbrief();
            Console.WriteLine(TAUCHZEIT);
            Console.WriteLine();
        }
    }
}