using Battleship.Core.Enums;
using Battleship.Core.Game;
using Battleship.Core.Bots;
using Spectre.Console;

namespace Battleship.ConsoleUI
{
    public class ConsoleUI
    {
        private Game _game;
        public void Run()
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(new FigletText("Battleship").Centered().Color(Color.Blue));

            var choice = AnsiConsole.Prompt(new SelectionPrompt<string>().AddChoices("Start game", "Quit"));

            if (choice == "Quit") return;

            _game = new Game(new RandomBot());
            _game.StartGame();
        }

        //public Coordinate ReadCoordinate()
        //{

        //}

        public void DisplayBoards(Board playerBoard, Board opponentBoard)
        {

        }

        public void DisplayTurn(GameState state)
        {

        }

        public void DisplayAttackResult(AttackResult result)
        {

        }

        public void DisplayWinner(Player winner)
        {

        }

    }
}
