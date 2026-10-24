using Battleship.Core.Enums;
using Battleship.Core.Models;

namespace Battleship.Core.Game
{
    public class FleetPlacer
    {
        public void PlaceFleet(Board board)
        {
            foreach (Ship ship in board.Fleet.Ships)
            {
                while (!board.TryPlaceShip(ship, GenerateRandomCoordinate(board.Size), GenerateRandomOrientation())) ;
            }
        }

        private Coordinate GenerateRandomCoordinate(int size)
        {
            return new Coordinate(Random.Shared.Next(size), Random.Shared.Next(size));
        }

        private Orientation GenerateRandomOrientation()
        {
            return Random.Shared.Next(2) == 0 ? Orientation.Horizontal : Orientation.Vertical;
        }
    }
}
