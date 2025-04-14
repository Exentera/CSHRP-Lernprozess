using System;
using Microsoft.Win32.SafeHandles;

namespace IT072406.Aufgaben.Aufgabe_7._2
{
    public class Wal : Wassertier
    {
        
        public Wal(string name, int tauchzeit) : base(name, tauchzeit)
        {
        }
        
        public override void Steckbrief()
        {
            Console.WriteLine($"Wal {name}");
            base.Steckbrief();
            Console.WriteLine(TAUCHZEIT);
            Console.WriteLine();
        }
    }
}