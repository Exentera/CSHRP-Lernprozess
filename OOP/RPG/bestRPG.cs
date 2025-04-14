using System;
using System.Threading;
using IT072406.OOP.Kaempfer;

namespace IT072406.OOP.RPG
{
    public class bestRPG
    {
        public static void Run()
        {
            Humanoid player = null;
            Humanoid gegner = null;
            
            Console.WriteLine("---------------------------------------------------");
            Console.Write("Dein Name ist: ");
            string playerName = Console.ReadLine();
            
            //Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Wähle dine Klase!");
            Console.WriteLine("Krieger\t(1)");
            Console.WriteLine("Magier\t(2)");
            Console.WriteLine("Jäger\t(3)");
            int selectedPlayerClass = Convert.ToInt32(Console.ReadLine()) ;
            switch (selectedPlayerClass)
            {
                case 1:
                    player = new Krieger(playerName,150,10,1);
                    break;
                case 2:
                    player = new Magier(playerName,120,15,1);
                    break;
                case 3:
                    player = new Jaeger(playerName,100,20,1);
                    break;
            }
            
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Wähle dienen Gegner!");
            Console.WriteLine("Gimlin\t(1)");
            Console.WriteLine("Gandalf\t(2)");
            Console.WriteLine("Legolas\t(3)");
            int selectedGegnerClass = Convert.ToInt32(Console.ReadLine()) ;
            switch (selectedGegnerClass)
            {
                case 1:
                    gegner = new Krieger("Gimlin",150,10,1);
                    break;
                case 2:
                    gegner = new Magier("Gandalf",120,15,1);
                    break;
                case 3:
                    gegner = new Jaeger("Legolas",100,20,1);
                    break;
            }
            //Console.Clear();

            
            // GAMELOOP
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"{gegner.name} will dir den Bordstein aus der, Nähe zeigen...");
            Console.WriteLine($"Der Kampf beginnt");
            Console.WriteLine("---------------------------------------------------");

            bool gameOver = false;

            do
            {   
                //PLAYER ANGRIFF
                player.Angriff(gegner);
                Console.WriteLine("---------------------------------------------------");
                if (player.lebenspunkte <= 0)
                {
                    Console.WriteLine($"{player.name} ist Krepiert!");
                    Console.WriteLine($"Game Over");
                    gameOver = true;
                    continue;
                }
                if (gegner.lebenspunkte <= 0)
                {
                    Console.WriteLine($"{gegner.name} ist Krepiert!");
                    Console.WriteLine($"{player.name} hat mit {gegner.name} den Boden aufgewischt.");
                    gameOver = true;
                    continue;
                }
                Thread.Sleep(500);
                
                //GEGNER ANGRIFF
                gegner.Angriff(player);
                Console.WriteLine("---------------------------------------------------");

                if (player.lebenspunkte <= 0)
                {
                    Console.WriteLine($"{player.name} ist Krepiert!");
                    Console.WriteLine($"Game Over");
                    gameOver = true;
                }
                if (gegner.lebenspunkte <= 0)
                {
                    Console.WriteLine($"{gegner.name} ist Krepiert!");
                    Console.WriteLine($"{player.name} hat mit {gegner.name} den Boden aufgewischt.");
                    gameOver = true;
                }
                Thread.Sleep(500);
                
            } while (gameOver == false);
        }
    }
}