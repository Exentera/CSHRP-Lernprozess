using System;

namespace IT072406.Aufgaben
{
    public class Aufgabe_5_7
    {
        public static void run()
        {
            string z1 = "",z2 = "",z3 = "",z4 = "";
            string pw = "PROG";

            int versuche = 3;
            
            char[] pwS = pw.ToCharArray();
            Array.Sort(pwS);
            
            string sPw = new string(pwS);
            string sEingabe;

            bool status = false;

            bool checkOk = true;
            
            while(status == false)
            {
                do
                {
                    Console.Write("1: ");
                    z1 = Console.ReadLine();
                    if (z1.Length > 1 || z1 == "")
                    {
                        Console.WriteLine("Nur EIN Zeichen pro eingeben... NOCHMAL VON VORNE!");
                        checkOk = false;
                        continue;
                    }

                    Console.Write("2: ");
                    z2 = Console.ReadLine();
                    if (z2.Length > 1 || z2 == "")
                    {
                        Console.WriteLine("Nur EIN Zeichen pro eingeben... NOCHMAL VON VORNE!");
                        checkOk = false;
                        continue;
                    }
                    
                    Console.Write("3: ");
                    z3 = Console.ReadLine();
                    if (z3.Length > 1 || z3 == "")
                    {
                        Console.WriteLine("Nur EIN Zeichen pro eingeben... NOCHMAL VON VORNE!");
                        checkOk = false;
                        continue;
                    }
                    
                    Console.Write("4: ");
                    z4 = Console.ReadLine();
                    if (z4.Length > 1 || z4 == "")
                    {
                        Console.WriteLine("Nur EIN Zeichen pro eingeben... NOCHMAL VON VORNE!");
                        checkOk = false;
                        continue;
                    }

                    checkOk = true;

                } while (checkOk == false);

                string eingabe = z1 + z2 + z3 + z4;
                Console.WriteLine($"Eingabe: {eingabe}");
                
                char[] eingabeS = eingabe.ToCharArray();
                Array.Sort(eingabeS);
                sEingabe = new string(eingabeS);
                if (sEingabe.ToUpper() == sPw.ToUpper())
                {
                    Console.WriteLine("LOGIN KORREKT!");
                    status = true;
                    break;
                }
                else
                {
                    versuche--;
                    Console.WriteLine($"{versuche} Versuche uebrig");
                }
                if (versuche == 0)
                {
                    break;
                }
            }
        }
    }
}