using Battleship.Core.Models;

namespace Battleship.Core.Game
{
    public class Fleet
    {
        private List<Ship> _ships;
        public IReadOnlyList<Ship> Ships { get; }
        public bool AllSunk { get; }

        public Fleet()
        {
            //TODO
        }

        public Ship FindShip(Coordinate coord)
        {
            //TODO
        }
    }
}
