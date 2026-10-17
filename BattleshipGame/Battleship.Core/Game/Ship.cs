using Battleship.Core.Enums;
using Battleship.Core.Models;

namespace Battleship.Core.Game
{
    public class Ship(int length)
    {
        private Coordinate _start;
        private Orientation _orientation;
        private int _remainingHitPoints;
        public int Length { get; } = length;
        public bool IsSunk { get; }

        public void SetPlacement(Coordinate coordinate, Orientation orientation)
        {
            //TODO
        }

        public bool Occupies(Coordinate coordinate)
        {
            //TODO
        }

        public bool RegisterHit()
        {
            //TODO
        }
    }
}
