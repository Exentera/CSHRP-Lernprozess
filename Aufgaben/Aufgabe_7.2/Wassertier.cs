using System;

namespace IT072406.Aufgaben.Aufgabe_7._2
{
    public class Wassertier : Tier , ITauchzeit
    {
        public Wassertier(string name, int tauchzeit)
        {
            this.name = name;
            this.TAUCHZEIT = tauchzeit;
        } 
        public int TAUCHZEIT { get; set; }

        public override void Steckbrief()
        {
            Console.Write("Tauchzeit: ");
        }

        
    }
}