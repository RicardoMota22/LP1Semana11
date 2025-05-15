using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class UglyView : IView
    {
        public Player AskforPlayerInfo()
        {
            // Variables
            string name;
            int score;
            Player newPlayer;

            // Ask for player info
            Console.WriteLine("\nInsert player");
            Console.WriteLine("-------------\n");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());

            // Create new player and add it to list
            newPlayer = new Player(name, score);
            playerList.Add(newPlayer);
        }
        public void ShowInvalidOptionMessage()
        {
            Console.WriteLine("Invalid option. Try again.");
        }

        public void ShowGoodbyeMessage()
        {
            Console.WriteLine("Bye!");
        }

        public void WaitForUser()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine("\n");
        }

        public string MainMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----\n");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List players with score greater than");
            Console.WriteLine("4. Sort players");
            Console.WriteLine("0. Quit\n");
            Console.Write("Your choice > ");
            return Console.ReadLine();
        }
    }
}