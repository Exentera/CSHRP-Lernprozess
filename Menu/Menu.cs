using System;

// String-Array als Eingabe für wählbare Optionen
// Gibt den Index der gewählten Option als int zurück

// Beispiel für Aufruf und Initialisierung:
// string[] optionen = { "Option_1", "Option_2", "Option_3", /* usw. */ };
// int gewählteOption = Menu.ShowMenu(optionen);

public class Menu
{
    public static int ShoweMenu(string[] optionen)
    {
        int auswahl = 0;
        ConsoleKey key;
        do
        {
            Console.Clear();
            for (int i = 0; i < optionen.Length; i++)
            {
                if (i == auswahl)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"> {optionen[i]}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($" {optionen[i]}");
                }
            }
            key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.UpArrow && auswahl > 0)
                auswahl--;
            else if (key == ConsoleKey.DownArrow && auswahl < optionen.Length - 1)
                auswahl++;
        } while (key != ConsoleKey.Enter);
        Console.Clear();
        return auswahl;
    }
}