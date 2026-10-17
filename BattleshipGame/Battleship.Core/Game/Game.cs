using Battleship.Core.Bots;
using Battleship.Core.Enums;
using Battleship.Core.Models;

namespace Battleship.Core.Game
{
    public class Game(IBot bot)
    {
        private Player _humanPlayer;
        private Player _botPlayer;
        private IBot _bot = bot;
        private FleetPlacer _fleetPlacer;
        public GameState State { get; private set; }
        public Player? Winner { get; private set; }
        public bool IsGameOver { get; }

        public void StartGame()
        {
            //TODO
        }

        public AttackResult Attack(Coordinate coordinate)
        {
            //TODO
        }

        public AttackResult ExecuteBotTurn()
        {
            //TODO
        }

    }
}
