using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public interface IView
    {
        void ShowGoodbyeMessage();
        void ShowInvalidOptionMessage();
        void WaitforUser();
        string MainMenu();
        Player AskforPlayerInfo();
        void ShowPlayers(IEnumerable<Player> playersToList);
        int AskforMinScore();
        PlayerOrder AskForPlayerOrder();
    }
}