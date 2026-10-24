using Battleship.Core.Models;

namespace Battleship.Core.Bots
{
    public class RandomBot : IBot
    {
        public Coordinate ChooseAttack(List<Coordinate> previousAttacks, int size)
        {
            Coordinate target;

            do
            {
                target = new Coordinate(Random.Shared.Next(size), Random.Shared.Next(size));
            } 
            while (previousAttacks.Contains(target));

            return target;
        }
    }
}
