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
            _humanPlayer = new Player("You", new Board());
            _botPlayer = new Player("Opponent", new Board());

            _fleetPlacer.PlaceFleet(_humanPlayer.Board);
            _fleetPlacer.PlaceFleet(_botPlayer.Board);



        }

        public AttackResult Attack(Coordinate coordinate)
        {
            if (_botPlayer.Board.IsWithinBounds(coordinate))
            {
                return _botPlayer.Board.Attack(coordinate);
            }

            return AttackResult.Invalid;
        }

        public AttackResult ExecuteBotTurn()
        {
            Coordinate attackCoordinate;

            do
            {
                attackCoordinate = _bot.ChooseAttack(_humanPlayer.Board.GetAttackedCoordinates(), _humanPlayer.Board.Size);
            } while (_humanPlayer.Board.Attack(attackCoordinate) == AttackResult.Invalid);

            return _humanPlayer.Board.Attack(attackCoordinate);

        }
    }
}
