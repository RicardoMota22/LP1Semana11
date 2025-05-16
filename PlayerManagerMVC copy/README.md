## Mermaid Class Diagram VSCode

```mermaid
classDiagram
    class Program {
        + Main(string[] args)
    }

    class Controller{
        - PlayersList playerList
        - UglyView view
        - IComparer<Player> compareByName
        - IComparer<Player> compareByNameReverse
        - Run (Iview view)
    }
    class Player {
        + string Name
        + int Score
        + Player(string name, int score)
    }

    class IView {
        + ShowGoodbyeMessage()
        + ShowInvalidOptionMessage()
        + WaitforUser()
        + MainMenu()
        + AskforPlayerInfo()
        + ShowPlayers(IEnumerable<Player> playersToList)
        + AskforMinScore()
        + AskForPlayerOrder()
    }
    class UglyView {
        
    }

    Program --> Controller
    Controller --> Player
    Controller --> IView
    UglyView ..|> IView
