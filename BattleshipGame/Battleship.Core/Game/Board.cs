using Battleship.Core.Enums;
using Battleship.Core.Models;
using System.Text;

namespace Battleship.Core.Game
{
    public class Board
    {
        private int _size;
        public int Size { get; }
        private Tile[,] _tiles;
        public Fleet Fleet { get; }
        public Board()
        {
            _size = 10;
            _tiles = new Tile[_size, _size];
        }

        public Tile GetTile(Coordinate coordinate)
        {
            return _tiles[coordinate.Y, coordinate.X];
        }

        public List<Coordinate> GetAttackedCoordinates()
        {
            List<Coordinate> coordinates = new List<Coordinate>();

            // Checking every tile & its state
            for (int row = 0; row < _size; row++)
            {
                for (int column = 0; column < _size; column++)
                {
                    Tile tile = _tiles[row, column];

                    if (tile.State == TileState.Hit || tile.State == TileState.Miss)
                    {
                        coordinates.Add(new Coordinate(row, column));
                    }
                }
            }

            return coordinates;
        }

        public bool IsWithinBounds(Coordinate coordinate)
        {
            return (coordinate.X < _size && coordinate.Y < _size && coordinate.X >= 0 && coordinate.Y >= 0) ? true : false;
        }

        public bool TryPlaceShip(Ship ship, Coordinate coordinate, Orientation orientation)
        {
            List<Coordinate> shipPoints = CalculatePositions(coordinate, orientation, ship.Length);
            
            if (AreWithinBounds(shipPoints))
            {
                for (int row = 0; row < _size; row++)
                {
                    for (int column = 0; column < _size; column++)
                    {
                        Tile tile = _tiles[row, column];

                        if (tile.State != TileState.Ship)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private List<Coordinate> CalculatePositions(Coordinate coordinate, Orientation orientation, int length)
        {
            List<Coordinate> coordinates = new List<Coordinate>();
            int baseX = coordinate.X;
            int baseY = coordinate.Y;
            coordinates.Add(coordinate);

            for (int i = 0; i < length; i++)
            {
                coordinates.Add(
                    orientation == Orientation.Horizontal
                    ? new Coordinate(i, baseY)
                    : new Coordinate(baseX, i)
                );
            }

            return coordinates;
        }

        private bool AreWithinBounds(List<Coordinate> positions)
        {
            foreach (Coordinate coordinate in positions)
            {
                if (!IsWithinBounds(coordinate))
                {
                    return false;
                }
            }
            return true;
        }

        public AttackResult Attack(Coordinate coordinate)
        {
            switch (_tiles[coordinate.Y, coordinate.X].State)
            {
                case TileState.Ship:
                    return AttackResult.Hit;
                case TileState.Water:
                    return AttackResult.Miss;
                case TileState.Hit:
                    return AttackResult.Invalid;
                case TileState.Miss:
                    return AttackResult.Invalid;
                default:
                    return AttackResult.Invalid;
            }
        }
    }
}