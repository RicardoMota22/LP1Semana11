using System;
using System.Collections.Generic;


namespace PlayerManagerMVC
{
    /// <summary>
    /// The player listing program.
    /// </summary>
    public class Program
    {
        /// The list of all players
        /// /// <summary>
        /// Program begins here.
        /// </summary>
        /// <param name="args">Not used.</param>
        private static void Main(string[] args)
        {
            // Create a new instance of the player listing program
            Program prog = new Program();
            // Start the program instance
            prog.Start();
        }

        Controller controller = new Controller(playerList, compareByName,
            compareByNameReverse);

        IView view = new UglyView();
        controller.Run(view)

    }
}
