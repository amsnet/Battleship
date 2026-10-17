using Battleship.Core.Enums;
using Battleship.Core.Models;

namespace Battleship.Core.Game
{
    public class Board
    {
        private int _size;
        private Tile[,] _tile;
        public Fleet Fleet { get; }
        public Board()
        {
            _size = 10;
        }

        public Tile GetTile(Coordinate coordinate)
        {

        }

        public List<Coordinate> GetAttackedCoordinates()
        {

        }

        public bool IsWithinBounds(Coordinate coordinate)
        {

        }

        public bool TryPlaceShip(Ship ship, Coordinate coordinate, Orientation orientation)
        {

        }

        private List<Coordinate> CalculatePositions(Coordinate coordinate, Orientation orientation, int length)
        {

        }

        private bool AreWithinBounds(List<Coordinate> positions)
        {

        }

        public AttackResult Attack(Coordinate coordinate)
        {

        }
    }
}
