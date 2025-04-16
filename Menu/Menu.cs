using System;

// String array as input for selectable options
// Returns the index of the selected option as an int

// Example for calling and initialization:
// string[] options = { "Option_1", "Option_2", "Option_3", /* etc. */ };
// int selectedOption = Menu.ShowMenu(options);



public class Menu
{
    /// <summary>
    /// Displays the menu
    /// </summary>
    /// <param name="options"></param>
    /// <returns></returns>
    public static int ShoweMenu(string[] options)
    {
        int selectedIndex = 0;
        ConsoleKey key;
        do
        {
            Console.Clear();
            for (int i = 0; i < options.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"> {options[i]}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($" {options[i]}");
                }
            }
            key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.UpArrow && selectedIndex > 0)
                selectedIndex--;
            else if (key == ConsoleKey.DownArrow && selectedIndex < options.Length - 1)
                selectedIndex++;
        } while (key != ConsoleKey.Enter);
        Console.Clear();
        return selectedIndex;
    }
}