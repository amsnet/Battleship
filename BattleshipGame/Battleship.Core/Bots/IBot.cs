using Battleship.Core.Models;

namespace Battleship.Core.Bots
{
    public interface IBot
    {
        public Coordinate ChooseAttack(List<Coordinate> previousAttacks);
    }
}
