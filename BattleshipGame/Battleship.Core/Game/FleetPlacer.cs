using Battleship.Core.Enums;
using Battleship.Core.Models;

namespace Battleship.Core.Game
{
    public class FleetPlacer
    {
        public void PlaceFleet(Board board)
        {

        }

        public Coordinate GenerateRandomCoordinate()
        {
            return new Coordinate(Random.Shared.Next(10), Random.Shared.Next(10));
        }

        public Orientation GenerateRandomOrientation()
        {
            return Random.Shared.Next(2) == 0 ? Orientation.Horizontal : Orientation.Vertical;
        }
    }
}
