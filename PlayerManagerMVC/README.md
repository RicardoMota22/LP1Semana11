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
        - Run(Iview view)
    }
    